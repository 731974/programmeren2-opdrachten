using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5to7
{
    public class Zoo
    {

        public void DisplayAnimalDetails(Animal animal)
        {

            Console.WriteLine(animal);

        }

        public void MakeAllAnimalsSound(Animal[] animals)
        {

            for (int i = 0; i < animals.Length; i++)
            {

                Animal animal = animals[i];
                Console.WriteLine(animal.MakeSound());

            }
        }
    }
}



