using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public string Species { get; set; }

        public Animal(string name, string species)
        {

            Name = name;
            Species = species;

        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"Animal Name: {Name}, Species: {Species}";
        }

        public virtual string Feed()
        {
            return $"Feeding {Name} the {Species}";
        }
    }
}
