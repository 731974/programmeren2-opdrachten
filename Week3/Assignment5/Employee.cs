using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public abstract class Employee : IEmployeeOperations
    {

        public string Name { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string jobTitle, decimal salary) {

            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
                
        }

        public void DisplayDetails()
        {
            Console.WriteLine("");
        }


        public decimal GetSalary()
        {
            return 0;
        }

        public abstract string GetJobDetails();
    }
}
