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
        decimal hourlyWage { get; set; }
        int hoursWorked { get; set; }

        public PartTimeEmployee(string name, string jobTitle, decimal hourlyRate, int hoursWorked) : base(name, jobTitle, (hourlyRate * hoursWorked))
        {
            this.hourlyWage = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
        }

        public override string GetJobDetails()
        {
            return "Part-time employee with hourly wage:";
        }

        public void GenerateReport()
        {
            Console.WriteLine("Employee Report:");
            base.DisplayDetails();
        }
    }
}
