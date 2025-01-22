using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Admin : User
    {
        public string Function { get; }

        public Admin(string name, string password, string function)  : base( name, password ) {
            Function = function;
        }


        public override string SaveFormat()
        {
            return base.SaveFormat() + $"|{Function}";
        }

        public override string ShowDetails()
        {
            return base.ShowDetails() + $"\nFunction: {Function}";
        }

    }
}
