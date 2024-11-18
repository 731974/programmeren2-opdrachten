using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class Elephant : Animal
    {

        public string Name;

        public Elephant(string name) : base(name, "Elephant")
        {
            Name = name;
        }

        public override string MakeSound()
        {

            return "Trumpet (Elephant)";
    
        }

        public override string Feed()
        {

            return "Feeding the elephant vegetables";

        }
    }
}
