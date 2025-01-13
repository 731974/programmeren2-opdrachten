using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ZooKeeper
    {
        // We maken gebruik van virtuale methods als we verschillende classes hebben die grotendeels dezelfde output hebben,
        // het stuk dat overeenkomt bij beide wordt gezet in de top virtuale class. De unieke stukken worden in de class
        // zelf toegevoegd doormiddel van een override.

        public string Name { get; }
        public string Departement { get;  }

        public ZooKeeper(string name, string departement)
        {

              Name = name;
              Departement = departement;

        }

        // Virtuale method MOET een body declareren 
        public virtual void DisplayAction()
        {

            Console.Write($"{Name} from {Departement} is");

        }

    }

    public class WorkBreak : ZooKeeper
    {
        public WorkBreak(string name, string departement) : base(name, departement) { }

        public override void DisplayAction()
        {
            base.DisplayAction(); // The first string is being used
            Console.Write(" taking a break\n");
        }
    }

    public class FeedingAnimals : ZooKeeper
    {
        private string _animal;

        public FeedingAnimals(string name, string departement, string animal) : base(name, departement) { 
        
            this._animal = animal;
        }

        public override void DisplayAction()
        {
            base.DisplayAction(); // The first string is being used
            Console.Write($" feeding the {_animal}");
        }

    }
}
