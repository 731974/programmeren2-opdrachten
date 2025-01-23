using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShipper
{
    public class PackageNotFoundException : Exception
    {
        public string Message { get; }
        public PackageNotFoundException(string message) : base(message)
        {
            Message = message;
        }
    }
}
