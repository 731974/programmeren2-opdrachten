using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Customer : User
    {
        public int BasketId { get; }

        public Customer(string name, string password, int basketID) : base(name, password)
        {
            BasketId = basketID;
        }


        public override string SaveFormat()
        {
            return base.SaveFormat() + $"|{BasketId}";
        }

        public override string ShowDetails()
        {
            return base.ShowDetails() + $"\nBasket ID: {BasketId}";
        }
    }
}
