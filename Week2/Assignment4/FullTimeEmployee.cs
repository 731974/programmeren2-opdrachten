using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment4
{


    public class FullTimeEmployee : Employee
    {

        decimal Salary;
        decimal CalculateBonusAmount;

        public FullTimeEmployee(string name, decimal salary) : base(name, salary)
        {

            Salary = salary;
            CalculateBonusAmount = CalculateBonus();
    }

        public override decimal CalculateBonus()
        {

            return (decimal)0.1 * this.Salary;
    
        }

        public override void DisplayEmployeeDetails()
        {

            Console.WriteLine($"Full-time Employee: {Name}");
            Console.WriteLine($"Salary: {Salary:F2}");
            Console.WriteLine($"Bonus: {CalculateBonusAmount:F2}");

        }

        public FullTimeEmployee() : base("", 0)
        {
            Salary = 0;
            CalculateBonusAmount = 0;
        }
    }
}
