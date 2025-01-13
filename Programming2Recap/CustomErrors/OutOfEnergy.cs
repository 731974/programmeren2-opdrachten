using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomErrors
{
    public class OutOfEnergy : Exception
    {
        public string Message { get; set; }
        public OutOfEnergy(string message) : base(message) { 
        
            Message = message;
        }  
    }
}
