namespace Assignment5to7
{
    public class Program
    {
        // leave this global variable as it will be used to handle error messages
        public List<string> logs = new List<string>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            // Sample code for assignment 5
            //Product product = new Product("Laptop", 10, 1000);
            //product.PrintDetails();
            //UpdateStock(product);
            //PrintAllLogs(logs);

            // Sample code for assignment 6
            List<Product> inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            DisplayInventory(inventory);
            OrderProduct(inventory);
            OrderProduct(inventory);
            OrderProduct(inventory);
            PrintAllLogs(logs);
            DisplayInventory(inventory);
        }


        public Order AskForOrder(List<Product> inventory)
        {
            Order order = null;

            try
            {
                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();
                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderManager orderManager = new();
                Product product = orderManager.CheckInventoryForProductName(inventory, productName);
                order = new(product, quantity);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: Product not found in inventory");
            }

            return order;
        }

        public void OrderProduct(List<Product> inventory)
        {

            try
            {
                Order order = AskForOrder(inventory);

                OrderManager orderManager = new();
                orderManager.ProcessOrder(inventory, order);
            }
            catch (InvalidOperationException productEx)
            {
                Console.WriteLine("Error: Insufficient stock.");
                AddLog("Error: Insufficient stock.");
            }
            catch (ArgumentException stockEx)
            {
                Console.WriteLine("Error: Product not found in inventory.");
                AddLog("Error: Product not found in inventory.");
            }
            catch (KeyNotFoundException ex)
            {
                AddLog("Error: Product not found in inventory.");
                Console.WriteLine("Error: Product not found in inventory.");
            }
        }

        public void DisplayInventory(List<Product> inventory)
        {
            Console.WriteLine("Inventory:");

            foreach (Product p in inventory)
            {
                Console.WriteLine($"Product: {p.Name}");
                Console.WriteLine($"Price: {p.Price:f2}");
                Console.WriteLine($"Current Stock: {p.Stock}");
                Console.WriteLine();
            }
        }

        public void AddLog(string log)
        {
            logs.Add(log);
        }

        public void UpdateStock(Product product)
        {
            try
            {
                Console.Write("Enter stock adjustment (negative to remove): ");
                int amount = int.Parse(Console.ReadLine());
                product.UpdateStock(amount);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                AddLog(ex.Message);
            }
            finally
            {
                Console.WriteLine($"Updated Stock for {product.Name}: {product.Stock}");
            }
        }

        public void PrintAllLogs(List<string> logs)
        {
            Console.WriteLine("Logs:");
            foreach (string log in logs)
            {
                Console.WriteLine($"- {log}");
            }
        }
    }
}
