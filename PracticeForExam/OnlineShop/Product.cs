using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Product
    {

        public int Id { get; }
        public string Name { get; set; } 
        public string Description { get;}
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                if (_stock - value > 0)
                    _stock = value;
            }
        }

        int _stock;

        public double Price { get; }

        public Product(int id, string name, string description, int stock, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Stock = stock;
            Price = price;
        }

        public virtual void DisplayInfo()
        {

            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Price: {Price}");

        }
    }
}
