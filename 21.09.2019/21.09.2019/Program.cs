using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._09._2019
{
    public struct Worker
    {
        public string name { get; set; }
        public string position { get; set; }
        public int year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value < 1950 && value > 2020)
                {
                    throw new Exception();
                }
                else
                {
                    this.year = value;
                }
            }
        }
    }

    class Program
    {



        static void Main(string[] args)
        {
            DateTime now = new DateTime();

            Worker[] worker = new Worker[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker: " + i);

                Console.WriteLine("Please enter name:");
                worker[i].name = Console.ReadLine();

                Console.WriteLine("Please enter position:");
                worker[i].position = Console.ReadLine();

                Console.WriteLine("Please enter year of employment.:");
                try
                {
                    worker[i].year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bad year");
                }
            }

            // Отримання стажу
            int experienceYear = 2;

            for (int i = 0; i < 5; i++)
            {
                if (now.Year - worker[i].year > experienceYear)
                {
                    Console.WriteLine($"Worker: {worker[i].name}");
                }
            }
        }
    }
}
