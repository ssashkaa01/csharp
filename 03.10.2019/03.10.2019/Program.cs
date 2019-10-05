using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._10._2019
{

    class OpArray
    {
        int[] arr;

        public OpArray(ref int[] numbers)
        {
            arr = numbers;
        }


        private bool isSimple(int number)
        {

            for (int i = 2; i < 10; i++)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        public int CountNegativeNumbers()
        {
            int count = 0;

            foreach(int i in arr)
            {
                if (i < 0) count++;
            }

            return count;
        }

        public int CountSimpleNumbers()
        {
            int count = 0;

            foreach (int n in arr)
            {
                if (isSimple(n)) count++;
            }

            return count;
        }

        public int SumAll()
        {
            int sum = 0;

            foreach (int i in arr)
            {
                if (i < 0) sum += i;
            }

            return sum;
        }

        public void ConvertNegativeToNull()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    arr[i] = 0;
                } 
            }   
        }

        public void SortToUp()
        {
            Array.Sort(arr);
        }

        public void DoubleElementsToFront()
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

        public int[] GetNumbers()
        {
            return arr;
        }

        public void Menu()
        {
            Console.WriteLine("1 - calculation");
            Console.WriteLine("2 - edit");
        }

        public void MenuEdit()
        {
            Console.WriteLine("Edit func:");
            Console.WriteLine("1 - Convert Negative Numbers to 0");
            Console.WriteLine("2 - Sort To Up");
            Console.WriteLine("3 - Double Value To Start");
        }

        public void MenuCalc()
        {
            Console.WriteLine("Calc func:");
            Console.WriteLine("1 - Count Negative Numbers");
            Console.WriteLine("2 - Count Simple Numbers");
            Console.WriteLine("3 - Sum All Numbers");
        }
    }


    class Program
    {
        public delegate void Edits();
        public delegate int Calcs();
        public delegate void Menu();

        static void Main(string[] args)
        {
      
            int[] numbers = new int[] { 1, 5, 0, 4, -9, 4, -12, 7, -12, 3, -2, 5};

            Console.WriteLine(string.Join(" ", numbers));

            OpArray oa = new OpArray(ref numbers);

            Edits[] ed = new Edits[]
            {
                oa.ConvertNegativeToNull,
                oa.SortToUp,
                oa.DoubleElementsToFront
            };

            Calcs[] ca = new Calcs[]
            {
                oa.CountNegativeNumbers,
                oa.CountSimpleNumbers,
                oa.SumAll
            };

            Menu[] m = new Menu[]
            {
                oa.Menu,
                oa.MenuCalc,
                oa.MenuEdit
            };

            

            m[0]();

            int cat = Convert.ToInt32(Console.ReadLine());

            m[cat]();

            int sub = Convert.ToInt32(Console.ReadLine());

            switch (cat)
            {
                case 1:
                    Console.WriteLine(ca[sub - 1]());
                    break;

                case 2:
                    ed[sub - 1]();
                    Console.WriteLine(string.Join(" ", oa.GetNumbers()));
                    break;

                default:
                    break;
            }
        }
    }
}
