using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Grade { get; set; }

        public Student(string name, int id, double grade)
        {
            Name = name;
            ID = id;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Student: {Name}, ID: {ID}, Grade: {Grade:f1}";
        }
    }
}
