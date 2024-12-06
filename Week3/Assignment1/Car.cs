using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine($"Car is driving");
        }
    }
}
