using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
   
        public class Student
        {

            public string Name { get; }
            public int Id { get; }
            public int Age { get; }
            public List<int> Grades { get; }

            public Student(string name, int id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
                Grades = new List<int>();
            }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Student ID: {Id}");
        }
    }

}
