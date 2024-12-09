using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class OrderManager
    {

        public Product CheckInventoryForProductName(List<Product> inventory, string productName)
        {
            Product? productFound = null;

            foreach (Product product in inventory) { 
                 if(product.Name == productName)
                    productFound = product;
            }

            if (productFound != null)
                return productFound;
            else
                throw new KeyNotFoundException("Error: Product not found in inventory.");
        }

        public void ProcessOrder(List<Product> inventory, Order order) 
        { 
            Product product = CheckInventoryForProductName(inventory, order.Product.Name); 
            
            if (product.Stock < order.Quantity) 
            { 
                throw new InvalidOperationException("Error: Insufficient stock."); 
            } 
            
            product.Stock -= order.Quantity;
        }
    }
}
