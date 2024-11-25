using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5to7
{
    public class PartTimeEmployee : Employee, IReportable
    {

        public decimal HourlyWage { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, string jobTitle, decimal hourlyRate, int hoursWorked) : base(name, jobTitle, hourlyRate * hoursWorked)
        {
            HourlyWage = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Part-time employee with hourly wage:");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Job Title: {this.JobTitle}");
            Console.WriteLine($"Salary: {this.GetSalary()}");
        }

        public decimal GetSalary()
        {
            return HourlyWage * HoursWorked;
        }

        public override string GetJobDetails()
        {
            return "Part-time employee with hourly wage:";
        }

        public void GenerateReport()
        {
            Console.WriteLine("Employee Report:");
            DisplayDetails();
        }
    }
}
