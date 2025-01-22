using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class UserNotFound : Exception
    {
        public string Message { get; }
        public UserNotFound(string message) : base(message) {
            Message = message;
        }
    }
}
