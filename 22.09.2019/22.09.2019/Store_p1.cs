using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._2019
{
    partial class Store
    {
        Product []products = new Product[] { };

        uint GetCountOfProducts()
        {
            uint count = 0;

            foreach (var item in products)
            { 
                count += item.Amount;   
            }

            return count;
        }

        uint GetCountOfProducts(ProductType type)
        {
            uint count = 0;

            foreach(var item in products)
            {
                if(item.Info.type == type)
                {
                    count += item.Amount;
                }
            }

            return count;
        }

        decimal GetTotalPrice()
        {
            decimal sum = 0;

            foreach (var item in products)
            {
                sum += (item.Amount*item.Info.price);
            }

            return sum;
        }

        decimal GetAveragePrice()
        {
            return this.GetTotalPrice() / this.GetCountOfProducts();
        }
    }
}
