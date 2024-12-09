﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public Product(string name, int stock, decimal price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine($"Price: {Price:f2}");
            Console.WriteLine($"Current Stock: {Stock}");
        }

        public void UpdateStock(int amount)
        {

            if(this.Stock + amount < 0)
            {
                throw new ArgumentException("Error: Amount exceeds stock.");
            } else
            {
                this.Stock += (int)amount;
            }
        }
    }
}
