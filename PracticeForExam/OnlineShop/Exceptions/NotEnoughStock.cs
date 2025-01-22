using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class NotEnoughStock : Exception
    {
        public string Message { get; }
        public NotEnoughStock(string message) : base(message) {
            Message = message;
        }
    }
}
