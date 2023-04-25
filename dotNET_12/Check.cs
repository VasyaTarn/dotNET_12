using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_12
{
    public struct Check
    {
        public List<Product> products;
        public Check(List<Product> products)
        {
            this.products = products;
        }
        public Product this[int index]
        {
            set
            {
                products[index] = value;
            }
            get
            {
                return products[index];
            }
        }
        public void AddProduct(Product t)
        {
            products.Add(t);
        }
        public void PrintAll()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < products.Count; i++)
            {
                products[i].PrintItem();
            }
            Console.ResetColor();
        }
    }
}
