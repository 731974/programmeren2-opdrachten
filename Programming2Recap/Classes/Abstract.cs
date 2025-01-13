using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal abstract class Animal
    {
        // Omdat het een abstracte class is, kan je ook abstracte methods maken, hierbij hoef je geen
        // body te declareren en kan je die dus laten overschrijven in de onderliggende classes die
        // overerven van de abstracte class.
        
        public abstract void MakeSound();

        // Goed om te onthouden is dat een interface alleen maar abstracte methods kan hebben terwijl een
        // abstracte class wel degelijk ook gevulde methods kan hebben, zoals hieronder te zien.

        public void Sleep()
        {
            Console.WriteLine($"{base.GetType().Name } is sleeping");
        }
    }

    internal class Wolf : Animal
    {
        // De wolf class erft over van animal, en MOET alle methods ook overnemen, wolf is geen abstracte class
        // dus moet het een body hebben voor de MakeSound() class, hierbij overschrijven we deze class. 

        public override void MakeSound()
        {
            Console.WriteLine("Woof, woof!");
        }

    }
}
