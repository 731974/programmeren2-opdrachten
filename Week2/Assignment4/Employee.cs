using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public abstract decimal CalculateBonus();

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Salary: {Salary:f2}");
            Console.WriteLine($"Bonus: {CalculateBonus():f2}");
        }

    }
}
