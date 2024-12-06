using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PartTimeEmployee
    {
        decimal HourlyWage;
        int HoursWorked;

        public PartTimeEmployee(decimal hourlyWage, int hoursWorked)
        {
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
        }

        public decimal GetSalary()
        {
            return HourlyWage * HoursWorked;
        }
    }
}
