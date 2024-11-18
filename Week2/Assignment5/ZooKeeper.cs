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

            for(int i = 0; i < animals.Length; i++)
            {

                Animal animal = animals[i];
               Console.WriteLine( animal.Feed());

            }

        }

    }
}