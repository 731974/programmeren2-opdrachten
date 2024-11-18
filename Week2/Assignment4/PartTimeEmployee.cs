using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class PartTimeEmployee : Employee
    {

        decimal Salary;
        decimal CalculateBonusAmount;

        public PartTimeEmployee(string name, decimal salary) : base(name, salary)
        {

            Salary = salary;
            CalculateBonusAmount = CalculateBonus();
        }

        public override decimal CalculateBonus()
        {

            return (decimal)0.05 * this.Salary;

        }

        public override void DisplayEmployeeDetails()
        {

            Console.WriteLine($"Part-time Employee: {Name}");
            Console.WriteLine($"Salary: {Salary:F2}");
            Console.WriteLine($"Bonus: {CalculateBonusAmount:F2}");

        }

    }
}
