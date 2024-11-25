using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PartTimeEmployee
    {


        public decimal HourlyWage { get; set; }
        public int HoursWorked { get; set; }

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
