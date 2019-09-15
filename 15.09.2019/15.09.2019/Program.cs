using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._09._2019
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
             1. Дано 2 масива розмірності M і N. 
             Необхідно переписати в третій масив спільні елементи перших
             двох масивів без повторень.
             */

            //int[] a = { 1, 2, 3, 4, 5, 6 };
            //int[] b = { 1, 5, 6, 7, 8 };
            //int[] c = a.Except(b).ToArray();

            //foreach (int i in c)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine();

            /*
             2. Користувач вводить рядок. Перевірити, чи є цей рядок паліндромом.
            паліндромом називається рядок,
            яка однаково читається зліва направо і справа наліво.
             */

            //string s = "bib";

            //char[] arr = s.ToCharArray();
            //Array.Reverse(arr);
            //string s2 = new string(arr);

            //if (s == s2)
            //{
            //    Console.WriteLine("good");
            //}
            //else
            //{
            //    Console.WriteLine("bad");
            //}

            /*
             3. Підрахувати кількість слів у введеному реченні.
             */

            //string str = "Дуже круте    речення!! ";
            //int count = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            //Console.WriteLine(count);

            /*
             4. Дано двовимірний масив розмірністю 5 × 5,
            заповнений випадковими числами з діапазону від -100 до 100.
            Визначити суму елементів масиву,
            розташованих між мінімальним і максимальним елементами.
             */

            //int[,] numbers = new int[5, 5];

            //Random ran = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        numbers[i, j] = ran.Next(-100, 100);
            //        Console.Write("{0}\t", numbers[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int sum = 0;
            //int min = numbers.Cast<int>().Min();
            //int max = numbers.Cast<int>().Max();

            //foreach (int item in numbers)
            //{
            //    if(item > min && item < max)
            //    {
            //        sum += item;
            //    }
            //}

            //Console.WriteLine($"Min: {min}\nMax: {max}\nSum: {sum}");

        }
    }
}