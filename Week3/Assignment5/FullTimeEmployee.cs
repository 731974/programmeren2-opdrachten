using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5to7
{
    public class FullTimeEmployee : Employee, IReportable
    {
        public decimal Salary;

        public FullTimeEmployee(string name, string jobTitle, decimal salary) : base(name, jobTitle, salary)
        {
            Salary = salary;
        }

        public decimal GetSalary()
        {
            return Salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("full-time employee with fixed salary:");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Job Title: {this.JobTitle}");
            Console.WriteLine($"Salary: {this.Salary}");
        }

        public override string GetJobDetails()
        {
            return "Full-time employee with fixed salary:";
        }

        public void GenerateReport()
        {
            Console.WriteLine("Employee Report:");
            DisplayDetails();
        }
    }
}
