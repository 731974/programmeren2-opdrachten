using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class ProductNotInShop : Exception
    {
        public string Message { get; }
        public ProductNotInShop(string message) : base(message) {
            Message = message;  
        }
    }
}
