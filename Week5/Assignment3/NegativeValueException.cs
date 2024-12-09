using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(string message) : base(message)
        {}
    }
}
