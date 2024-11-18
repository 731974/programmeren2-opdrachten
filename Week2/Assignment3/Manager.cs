using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Manager : Employee
    {

        public string Department;

        public Manager(string name, int age, string jobTitle, string department) : base(name, age, jobTitle) {

            Department = department;
        }

        public override string ToString()
        {
            return $"Manager: {Name}, Age: {Age}, Job Title: {JobTitle}, Department: {Department}";
        }

    }
}
