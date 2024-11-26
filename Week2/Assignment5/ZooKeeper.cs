using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class ZooKeeper
    {

        public void FeedAnimals(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Feed());
            }
        }
    }
}