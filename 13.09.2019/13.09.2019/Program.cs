using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Завдання 1: Написати програму, яка зчитує символи з клавіатури, 
             поки не буде введена точка. 
             Програма повинна порахувати кількість введених користувачем пробілів.
             */

            //string str = Console.ReadLine();
            //str = str.Split('.')[0];
            //Console.WriteLine(str);

            /*
             Завдання 2. Ввести з клавіатури номер трамвайного квитка (6-значне число) 
             і провірити чи є даний квиток щасливим 
             (якщо на квитку надруковано шестизначне число, 
             і сума перших трьох цифр дорівнює сумі останніх трьох, 
             то цей квиток вважається щасливим). 
             */

            //string number = Console.ReadLine();

            //if(number.Length == 6)
            //{
            //    int n1 = 0;
            //    int n2 = 0;

            //    for (int i = 0; i < 6; i++)
            //    {
            //        if(i < 3)
            //        {
            //            n1 += Convert.ToInt32(number[i]);
            //        }
            //        else
            //        {
            //            n2 += Convert.ToInt32(number[i]);
            //        }
            //    }

            //    if(n1 == n2)
            //    {
            //        Console.WriteLine("You have happy number!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("It`s not happy number...");
            //    }
            //}

            /*
             Завдання 3: Дано цілі додатні числа A і B (A <B). 
             Вивести всі цілі числа від A до B включно; 
             кожне число має виводитися на новому рядку; 
             при цьому кожне число повинне виводитися кількість разів, 
             рівне його значенню. Наприклад: якщо А = 3, а В = 7, 
             то програма повинна сформувати в консолі наступний вивід:
	            3 3 3
	            4 4 4 4
	            5 5 5 5 5
	            6 6 6 6 6 6
	            7 7 7 7 7 7 7

             */

            //int a = 3;
            //int b = 7;

            //for (int i = a; i <= b; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.Write("\n");
            //}

            /*
             Завдання 4: Дано ціле число N (> 0), знайти число, 
             отримане при прочитанні числа N справа наліво. 
             Наприклад, якщо було введено число 345, 
             то програма повинна вивести число 543.
             */

            //string numb = Console.ReadLine();

            //numb = new String(numb.Reverse().ToArray());

            //Console.WriteLine(numb);

            /*
             Завдання 5: Початковий внесок в банку дорівнює 10000 грн. 
             через місяця розмір вкладу збільшується на P відсотків від наявної суми 
             (P - дробове число, 0 <P <25). Значення Р програма повинна отримувати у користувача. 
             За даним P визначити через скільки місяців розмір вкладу перевищить 11000 грн., 
             і вивести знайдену кількість місяців K (ціле число) і 
             підсумковий розмір вкладу S (дробове число). 
             */

            //decimal capital = 10000;

            //decimal rate = Convert.ToDecimal(Console.ReadLine()); // %

            //int months = 0;

            //while(capital < 11000)
            //{
            //    capital += capital * (rate / 100);
            //    months++;
            //}

            //Console.WriteLine($"Months: {months} \nSum: {capital}");
        }
    }
}
