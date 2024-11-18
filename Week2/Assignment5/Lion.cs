using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class Lion : Animal
    {

        public string Name;

        public Lion(string name) : base(name, "Lion")
        {
            Name = name;
        }

        public override string MakeSound()
        {

            return "Roar (Lion)";

        }

        public override string Feed()
        {

            return "Feeding the lion meat";

        }
    }
}
