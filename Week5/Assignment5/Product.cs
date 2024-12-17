namespace Assignment5to7
{
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public Product(string name, int stock, decimal price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine($"Price: {Price:f2}");
            Console.WriteLine($"Current Stock: {Stock}");
        }

        public void UpdateStock(int amount)
        {
            if (Stock + amount < 0)
                throw new ArgumentException("Error: Amount exceeds stock.");
            else
                Stock += (int)amount;
        }
    }
}