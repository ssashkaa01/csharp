using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._09._2019
{

    class Calculator
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Sub(float a, float b)
        {
            return a - b;
        }

        public static float Div(float a, float b)
        {

            if(b == 0)
            {
                throw new Exception("Div on 0");
            }

            return a / b;
        }

        public static float Mul(float a, float b)
        {
            return a * b;
        }
    }

    public struct Worker
    {
        private int year;
        
        public string Name { get; set; }
        public string Position { get; set; }
       
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value > 1950 && value < 2020)
                {
                    this.year = value;
                    
                }
                else
                {
                    throw new Exception("Year is bad");
                }
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Calculator.Div(1, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " +e.Message);
            }

            DateTime now = new DateTime();

            Worker[] worker = new Worker[5];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Worker: " + (i+1));

                Console.WriteLine("Please enter name:");
                worker[i].Name = Console.ReadLine();

                Console.WriteLine("Please enter position:");
                worker[i].Position = Console.ReadLine();

                Console.WriteLine("Please enter year of employment.:");
                try
                {
                    worker[i].Year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }
            }

            // Отримання стажу
            int experienceYear = 2;

            for (int i = 0; i < 5; i++)
            {
                if (now.Year - worker[i].Year > experienceYear)
                {
                    Console.WriteLine($"Worker: {worker[i].Name}");
                }
            }
        }
    }
}
