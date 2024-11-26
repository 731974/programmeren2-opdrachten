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
            return 0.05M * Salary;
        }

        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Part-time Employee: {Name}");
            base.DisplayEmployeeDetails();
        }
    }
}
