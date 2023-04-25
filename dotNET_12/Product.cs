using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_12
{
    public struct Product
    {
        private string name;
        private double cost;
        private double discount;
        private string text;
        private int quantity;
        public Product(string name, double cost, double discount, string text, int quantity)
        {
            this.name = name;
            this.cost = cost;
            this.discount = discount;
            this.text = text;
            this.quantity = quantity;
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public double Cost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;
            }
        }
        public double Discount
        {
            set
            {
                discount = value;
            }
            get
            {
                return discount;
            }
        }
        public string Text
        {
            set
            {
                text = value;
            }
            get
            {
                return text;
            }
        }
        public int Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        public double TotalPrice
        {
            get
            {
                return quantity * cost * (1 - discount / 100);
            }
        }
        public void PrintItem()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Cost: {cost}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Total cost: {TotalPrice}");
            Console.WriteLine($"Wish: {text}");
        }
    }
}
