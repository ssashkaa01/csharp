using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._09._2019
{
    class Student
    {
      
        public static string name { get; set; }

        public static int age { get; set; }
        
        public static DateTime birthday { get; set; }

        public float balance { get; set; }

        public decimal rating { get; set; }
        
        public Student(string name, int age, float balance, DateTime birthday, decimal rating)
        {
            Student.name = name;
            Student.age = age;
            this.balance = balance;
            Student.birthday = birthday;
            this.rating = rating;
        }
        static Student()
        {
            Student.name = "No name";
            Student.age = 0;
            //this.balance = 0;
            Student.birthday = new DateTime(2000, 1, 1);
            //this.rating = 0;
        }

        public Student()
        {
            Student.name = "No name";
            Student.age = 0;
            this.balance = 0;
            Student.birthday = new DateTime(2000, 1, 1);
            this.rating = 0;
        }
        
        public void SetParam(ref string name, ref int age, ref float balance, ref DateTime birthday, ref decimal rating)
        {
            Student.name = name;
            Student.age = age;
            this.balance = balance;
            Student.birthday = birthday;
            this.rating = rating;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"birthday: {birthday}");
        }

        public static void Shows()
        {
            Console.WriteLine($"Name: {Student.name}");
            Console.WriteLine($"Age: {Student.age}");
            Console.WriteLine($"birthday: {Student.birthday}");
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Student []st2 = new Student[5];
            //Student st2;


            st2[0] = new Student();
            st2[0].Show();

            st.Show();

          //  Student.Shows();
        }
    }
}
