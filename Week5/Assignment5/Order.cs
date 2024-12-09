using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class Order
    {

        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Order(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
