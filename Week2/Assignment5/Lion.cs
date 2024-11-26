using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class Lion : Animal
    {

        public string Name { get; set; }

        public Lion(string name) : base(name)
        {
            Name = name;
        }

        public override string MakeSound()
        {

            return $"Roar ({this.GetType().Name})";

        }

        public override string Feed()
        {

            return base.ToString() + "meat";

        }
    }
}
