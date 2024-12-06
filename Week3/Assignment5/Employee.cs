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

        protected Employee(string name, string jobTitle, decimal salary) {
            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine(GetJobDetails());
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine($"Salary: {Salary}");
        }

        public decimal GetSalary()
        {
            return Salary;
        }
        
        public abstract string GetJobDetails();
    }
}
