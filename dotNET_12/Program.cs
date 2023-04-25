using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product p = new Product("name1", 11, 22, "text1", 33);
            Check check = new Check(products);
            check.AddProduct(p);
            check.PrintAll();
        }
    }
}
