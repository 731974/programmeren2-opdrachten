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

        public override void DisplayDetails()
        {
            base.DisplayDetails();
        }

        public override string GetJobDetails()
        {
            return "Full-time employee with fixed salary:";
        }

        public void GenerateReport()
        {
            Console.WriteLine("Employee Report:");
            base.DisplayDetails();
        }
    }
}
