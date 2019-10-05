using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10._2019
{
    class Cards
    {
        Queue<int> q;

        public Cards()
        {
            q = new Queue<int>();

            for (int i = 1; i <= 36; i++)
            {
                q.Enqueue(i);
            }

            Console.WriteLine("Cards ready!");
        }

        public void GetPlayerCards()
        {
                 
        }

        public void MixCards()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             Завдання 1:
             Реалізувати PhoneBook на дженерік колекції Dictionary<TKey, TValue>, 
             функціональність залишити на тому ж рівні.
            */

            //Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            //PhoneBook.Add("+380991116677", "Friend");

            //foreach(var contact in PhoneBook)
            //{
            //    Console.WriteLine($"{contact.Value} - {contact.Key}");
            //}

            /*
            Завдання 2:
            Знайти в колекції типу List<string> максимальне по довжині слово, 
            якщо таких виявляється кілька, виводимо на екран те, 
            яке стоїть раніше в словнику(алфавіті).
            */

            //List<string> words = new List<string>() { "ddefr", "absdre", "abcdrt", "swdf", "dddgg", "adz323" };

            //words.Sort();
            //var res = words.OrderByDescending(s => s.Length);

            //Console.WriteLine(res.First());

            /*      
            Завдання 3:
            Колекцію типу ArrayList ініціалізувати випадковими данними 3-ох типів: bool, int, double. 
            Реалізувати розбиття базової колекції на 3 різних: List<bool>, List<int>, List<double>. 
            Забезпечити перевірку колекцій виводом на екран.
            */

            //ArrayList al = new ArrayList() { true, true, 2.4, 6, false, 56, 100, 8.9, 3.5 , 2, false, 3 };

            //List<bool> lb = new List<bool>();
            //List<int> li = new List<int>();
            //List<double> ld = new List<double>();

            //foreach(var item in al)
            //{
            //    switch (Convert.ToString(item.GetType()).Substring(7))
            //    {
            //        case "Double":
            //            ld.Add(Convert.ToDouble(item));
            //            break;
            //        case "Int32":
            //            li.Add(Convert.ToInt32(item));
            //            break;
            //        case "Boolean":
            //            lb.Add(Convert.ToBoolean(item));
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //foreach(bool item in lb)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (int item in li)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (double item in ld)
            //{
            //    Console.WriteLine(item);
            //}

            /*
            Завдання 4:
            Реалізувати функціональність колоди карт, на базі контейнера Queue, 
            реалізувати метод отримання карти з колоди, 
            метод роздачі по 6 штук за раз, перемішування колоди і тд.
             */

            //Cards c = new Cards();
           
        }
    }
}
