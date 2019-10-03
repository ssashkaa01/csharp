using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._10._2019
{

    class OpArray
    {

        private static bool isSimple(int number)
        {

            for (int i = 2; i < 10; i++)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        public static int CountNegativeNumbers(int[] arr)
        {
            int count = 0;

            foreach(int i in arr)
            {
                if (i < 0) count++;
            }

            return count;
        }

        public static int CountSimpleNumbers(int[] arr)
        {
            int count = 0;

            foreach (int n in arr)
            {
                if (isSimple(n)) count++;
            }

            return count;
        }

        public static int SumAll(int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                if (i < 0) sum += i;
            }

            return sum;
        }

        public static void ConvertNegativeToNull(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    arr[i] = 0;
                } 
            }   
        }

        public static void SortToUp(ref int[] arr)
        {
            Array.Sort(arr);
        }

        public static void DoubleElementsToFront(ref int[] arr)
        {

            List<int> newarr = new List<int>();

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    newarr.Insert(0, i);
                }
                else
                {
                    newarr.Add(i);
                }
            }

            arr = newarr.ToArray();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 5, 0, 4, -9, 4, -12, 7, -12, 3, -2, 5};
            Console.WriteLine(string.Join(" ", numbers));

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("1 - calculation");
            Console.WriteLine("2 - edit");

            //OpArray.ConvertNegativeToNull(ref numbers);
            //OpArray.SortToUp(ref numbers);
            //OpArray.DoubleElementsToFront(ref numbers);
            Console.WriteLine(string.Join(" ", numbers));







            // Я ДОРОБЛЮ ДОМАШКУ ДО 06.10.19 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!








            int action = Convert.ToInt32(Console.ReadLine());
        }
    }
}
