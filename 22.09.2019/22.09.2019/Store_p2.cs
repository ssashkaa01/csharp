using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._2019
{
    partial class Store
    {
        public override string ToString()
        {

            string all = "";

            foreach (var item in products)
            {
                all += "Code: " + item.Info.code + " :: Name: " + item.Info.name + " :: Price: " + item.Info.price + "\n";
            }

            return all;
        }

        public Product GetProduct(int code)
        {

            foreach (var item in products)
            {
                if (item.Info.code == code)
                {
                    return item;
                }
            }

            throw new Exception("Bad code");
        }

        public void DeleteProduct(int code)
        {
            products = products.Where(item => item.Info.code != code).ToArray();
        }

        public void AddProduct(ref Product prod)
        {
            if (prod.Info.name == null) throw new ArgumentNullException("Bad Prod");

            Array.Resize(ref products, products.Length + 1);
            products[products.GetUpperBound(0)] = prod;
        }
    }
}
