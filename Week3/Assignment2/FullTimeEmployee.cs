using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class FullTimeEmployee : IEmployee
    {

        public decimal Salary { get; }

        public FullTimeEmployee(decimal salary)
        {
            Salary = salary;
        }

        public decimal GetSalary()
        {
            return Salary;
        }
    }
}
