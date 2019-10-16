using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._10._2019
{

    struct Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    struct Product
    {
        public int id { get; set; }
        public int id_category { get; set; }
        public int year { get; set; }
        public int price { get; set; }
        public string country { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"Name: {name}\nPrice: {price}\nCountry: {country}\nYear: {year}\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Category[] categories = new Category[]
            {
                new Category(){ id = 1, name = "TV"},
                new Category(){ id = 2, name = "Phone"},
                new Category(){ id = 3, name = "PC"},
            };

            Product[] products = new Product[]
            {
                new Product(){ id = 1, id_category = 2, year = 2019, price = 12999, country = "China", name = "Posa Galaxy S8"},
                new Product(){ id = 2, id_category = 2, year = 2018, price = 7699, country = "China", name = "Kile ks90"},
                new Product(){ id = 3, id_category = 3, year = 2017, price = 45000, country = "UK", name = "Fusoa p190"},
                new Product(){ id = 4, id_category = 2, year = 2019, price = 16799, country = "USA", name = "Ioa 0091"},
                new Product(){ id = 5, id_category = 1, year = 2018, price = 9000, country = "Ukraine", name = "Popos o89"},
            };


            /*
             Завдання 1:
             Вибрати всі товари, які виготовлені в теперішньому році. 
             Відсортувати їх за принципом: від найдорожчого до найдешевшого.
            */

            //var res = from item in products
            //          where item.year == DateTime.Now.Year
            //          orderby item.price descending
            //          select item;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            /*
            Завдання 2:
            Знайти кількість продуктів, що виготовлені у вибраній країні.
            */

            //var res = from item in products
            //          where item.country == "China"
            //          select item;

            //Console.WriteLine($"Count: {res.Count()}\n");


            /*
            Завдання 3:
            Знайти найдорожчий та найдешевший продукт вибраної категорії.
            */

            //var res = from item in products
            //          where item.id_category == 2
            //          orderby item.price ascending
            //          select item;

            //Console.WriteLine($"Big price:");
            //Console.WriteLine(res.Last());

            //Console.WriteLine($"Min price:");
            //Console.WriteLine(res.First());


            /*
            Завдання 4:
            Показати назви категорій, продукти яких не виготовляються в Україні.
             */

            //var res = from cat in categories
            //          join item in products on cat.id equals item.id_category
            //          where item.country != "Ukraine"
            //          select cat.name;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
