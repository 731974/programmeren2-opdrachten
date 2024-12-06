using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Bike : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine($"Bike is pedaling");
        }
    }
}
