using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Завдання 1:
            Дано цілочисельну послідовність.
            Витягти з неї всі позитивні числа, 
            відсортувавши їх по зростанню. (можна використати Where, OrderBy)
            */

            //int[] numbers = { -7, 3, 45, -67 , 12, -9, 90, 45 };

            //var res = from num in numbers
            //          where num >= 0
            //          orderby num ascending
            //          select num;
            //foreach(var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            /*
            Завдання 2:
            Дано колекцію цілих чисел. 
            Знайти кількість позитивних двозначних елементів, 
            а також їх середнє арифметичне. (Where, Avg)
            */


            //int[] numbers = { -7, 30, 45, -67 , 12, -9, 90, 45 };

            //var res = from num in numbers
            //          where num % 2 == 0
            //          orderby num ascending
            //          select num;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Count: {res.Count()}");
            //Console.WriteLine($"Average: {res.Average()}");

            /*
            Завдання 3:
            Дано колекцію непустих рядків. 
            Отримати рядок, що складається з початкових символів 
            всіх рядків вхідної послідовності. (Aggregate)
            */

            //string[] strings = { "sdfsdg", "aadlkflk", "werwewe", "deweoiewio", "easdgsdgasdg" };

            //var res = strings.Aggregate($"", (concat, str) => $"{concat}{str[0]}");

            //Console.WriteLine(res);

            /*
            Завдання 4:
            Дано колекцію непустих рядків A.
            Отримати колекцію символів, 
            кожен елемент якої є початковим символом відповідного рядка з A. 
            Порядок символів повинен бути зворотнім по відношенню до порядку елементів вхідної колекції. 
            (SelectMany з урахуванням того, що рядок можна конвертувати в колекцію символів). 
            */

            //string[] strings = { "sdfsdg", "aadlkflk", "werwewe", "deweoiewio", "easdgsdgasdg" };

            //var res = from str in strings
            //          select str[0];

            //res = res.Reverse();

            //foreach (var item in res)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
        }
    }
}
