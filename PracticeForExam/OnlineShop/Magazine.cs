using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Magazine : Product
    {
        public int Number { get; }

        public Magazine(int id, string name, string description, int stock, double price, int number) : base(id, name, description, stock, price)
        {   
            Number = number;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number: {Number}");
        }

    }
}
