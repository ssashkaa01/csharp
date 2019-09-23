using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine("Product");
            // create product
            var prod = new Product();
            //prod.Show();

            store.AddProduct(ref prod);
            Console.WriteLine(store.ToString());

            store.DeleteProduct(1000);
            Console.WriteLine(store.ToString());


            //Console.WriteLine("Provider");
            // create provider
            // var prov = new Provider("Vitia", "Brasil");
            // prov.Show();
        }
    }
}
