namespace Assignment5to7
{
    public class OrderManager
    {
        public Product CheckInventoryForProductName(List<Product> inventory, string productName)
        {
            foreach (Product product in inventory)
            {
                if (product.Name == productName)
                    return product;
            }

            throw new KeyNotFoundException("Error: Product not found in inventory.");
        }

        public void ProcessOrder(List<Product> inventory, Order order)
        {
            Product product = CheckInventoryForProductName(inventory, order.Product.Name);

            if (product.Stock < order.Quantity)
                throw new InvalidOperationException("Error: Insufficient stock.");

            product.UpdateStock(-order.Quantity);
        }
    }
}
