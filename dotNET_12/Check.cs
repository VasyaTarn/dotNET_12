using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_12
{
    class Check
    {
        public List<Product> tovars;
        public Check()
        {
            this.tovars = new List<Product>();
        }
        public Product this[int index]
        {
            set
            {
                tovars[index] = value;
            }
            get
            {
                return tovars[index];
            }
        }
        public void AddProduct(Product t)
        {
            tovars.Add(t);
        }
        public void PrintAll()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < tovars.Count; i++)
            {
                tovars[i].PrintItem();
            }
            Console.ResetColor();
        }
    }
}
