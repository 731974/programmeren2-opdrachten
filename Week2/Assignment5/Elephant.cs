using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class Elephant : Animal
    {
        public string Name { get; set; }

        public Elephant(string name) : base(name)
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return $"Trumpet ({this.GetType().Name})";
        }

        public override string Feed()
        {
            return base.ToString() + " vegetables";
        }
    }
}
