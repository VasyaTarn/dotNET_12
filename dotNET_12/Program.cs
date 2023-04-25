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
            Product p = new Product("name1", 11, 22, "text1", 33);
            Check check = new Check();
            check.AddProduct(p);
            check.PrintAll();
        }
    }
}
