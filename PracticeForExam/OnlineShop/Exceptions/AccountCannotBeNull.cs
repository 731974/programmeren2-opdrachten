using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class AccountCannotBeNull : Exception
    {
        public AccountCannotBeNull( string message) : base(message) { }
    }
}
