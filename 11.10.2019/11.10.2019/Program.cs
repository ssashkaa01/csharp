using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _11._10._2019
{

    class FileSystem
    {
        public string position { get; set; }
        public string action { get; set; }
        public bool exit { get; set; }

        public FileSystem()
        {
            position = Environment.CurrentDirectory;
        }

        public FileSystem(string path)
        {
            position = path;
        }

        public void ViewDirInfo(string dirName)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Название каталога: {0}", dirInfo.Name);
            Console.WriteLine("Полное название каталога: {0}", dirInfo.FullName);
            Console.WriteLine("Время создания каталога: {0}", dirInfo.CreationTime);
            //Console.WriteLine("Корневой каталог: {0}", dirInfo.Root);
        }

        // Переглянути вміст папки
        public void Ls()
        {
            DirectoryInfo di = new DirectoryInfo(position);

            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (var item in di.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in di.GetFiles())
            {
                Console.WriteLine(item.Name);
            }

        }

        //Переміщення по папках
        public void Cd(string path)
        {
            switch(path)
            {
                case "..":
                    position = position.Substring(0, position.Length - GetPwdDirName().Length - 1);
                    break;

                default:

                    if (!CheckName(path))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bad path");
                        return;
                    }
                    else if(!Directory.Exists(position + '\\' + path))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Directory not faund");
                        return;
                    }

                    position = position + '\\' + path;

                    break;
            }
        }

        // Створити папку
        public void Mkdir(string name)
        {
            if(!CheckName(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bad name of directory");
                return;
            }

            if (!Directory.Exists(position + '\\' + name))
            {
                Directory.CreateDirectory(position + '\\' + name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Directory was created!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory exists!");
            }
        }
        // Видалити папку
        public void Rmdir(string name)
        {
            if (!CheckName(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bad name of directory");
                return;
            }

            if (Directory.Exists(position + '\\' + name))
            {
                Directory.Delete(position + '\\' + name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Directory was deleted!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Directory not exists!");
            }
        }


        // Переглянути позицію в файловій системі
        public void Pwd()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(position);
            Console.WriteLine(dirInfo.FullName);
        }

        // Отримати назву папки, в якій ми зараз знаходимось
        public string GetPwdDirName()
        {
            return $"{position.Split('\\').Last()}";
        }

        // Обробка команд з консолі
        public void CheckCommand()
        {
            string[] command = action.Split(' ');

            try
            {
                switch (command[0])
                {
                    case "pwd":
                        Pwd();
                        break;
                    case "cd":
                        Cd(command[1]);
                        break;
                    case "ls":
                        Ls();
                        break;

                    case "mkdir":
                        Mkdir(command[1]);
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    case "rmdir":
                        Rmdir(command[1]);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Command not faund!");
                        break;
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Command is bad!");
            }
            
        }

        // Очікування команди
        public void WaitCommand()
        {
            exit = false;

            Console.WriteLine($"[root@mypc {GetPwdDirName()}]# You are successful connected!");

            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write($"[root@mypc {GetPwdDirName()}]# ");

                action = Convert.ToString(Console.ReadLine());

                CheckCommand();
            }

            Console.WriteLine("You are disconnected!");
        }

        // Перевірити назву на коректність
        public bool CheckName(string name)
        {
            return Regex.Match(name, @"^[A-Za-z0-9]{1,30}$").Success;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FileSystem fs = new FileSystem();
            fs.WaitCommand();
        }
    }
}
