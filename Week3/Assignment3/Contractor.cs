using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Contractor : IPayable, IWorkable
    {
        decimal HourlyRate;
        int HoursWorked;

        public Contractor(decimal hourlyRate, int hoursWorked)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public void Work()
        {
            Console.WriteLine("Contractor is working");
        }

        public decimal GetPayment()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
