using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Vehicle
    {
        public string Model { get; set; }
        
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
    }
}