using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class ProductManager
    {

        Dictionary<int, Product> products = new Dictionary<int, Product>();
        List<Product> productsList = new List<Product>();

        public void AddProductToShop(Product p)
        {
            products.Add(p.Id, p);
            productsList.Add(p);
        }

        public Product FindProductById(int id)
        {
            try
            {
                foreach (Product p in productsList)
                    if (p.Id == id) return p;
                    else
                        throw new ProductNotInShop("Error: Sorry the requested product is not for sale in our shop!");

            }
            catch ( ProductNotInShop ex ) {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public void PurchaseItem(int id, int basketId, int amount)
        {

            Product p = FindProductById(id);

            if (p.Stock - amount < 0)
                throw new NotEnoughStock("Error: We don't have the requested amount in stock!");

            AccountManager am = new("../../../records.txt");

            User u = am.FindUserByBasketId(basketId);

            p.Stock -= amount;
        }
    }
}
