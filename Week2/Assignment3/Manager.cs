using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, int age, string jobTitle, string department) : base(name, age, jobTitle) {

            Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + $", Department: {Department}";
        }
    }
}