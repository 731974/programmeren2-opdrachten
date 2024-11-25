using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public interface IEmployeeOperations
    {

        void DisplayDetails();

        decimal GetSalary();

        abstract string GetJobDetails();
        

    }
}
