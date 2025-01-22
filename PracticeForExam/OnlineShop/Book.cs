using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Book : Product
    {

        public string Series { get; }

        public Book(int id, string name, string description, int stock, double price, string series) : base(id, name, description, stock, price)
        {
            Series = series;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Serie: {Series}");
        }

    }
}
