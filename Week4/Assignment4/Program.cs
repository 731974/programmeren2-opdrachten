namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            List<Product> products = new List<Product>();

            Product product0 = new("Stroopwafel", 2.00, (Category)Enum.Parse(typeof(Category), "Kitchenware"));
            Product product1 = new("Mes", 21.00, (Category)Enum.Parse(typeof(Category), "Kitchenware"));
            Product product2 = new("Lepel", 112.00, (Category)Enum.Parse(typeof(Category), "Kitchenware"));
            Product product3 = new("Plant", 5.00, (Category)Enum.Parse(typeof(Category), "Stationary"));
            Product product4 = new("Sleutel", 115.00, (Category)Enum.Parse(typeof(Category), "Stationary"));

            products.Add(product0);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            PrintProducts(products);
            SortByPrice(products);

        }


        public void PrintProducts(List<Product> products)
        {

            for (int i = 0; i < products.Count; i++)
            {

                Console.WriteLine($"{i+1}. {products[i]}");

            }
        }

        public void SortByPrice(List<Product> products)
        {
            products.Sort((a, b) => b.Price.CompareTo(a.Price));
        }

        public List<Product> FilterByCategory(List<Product> products, Category category)
        {

            List<Product> filtered = new List<Product>();

            foreach (Product product in products) { 
            
                if (product.Category == category)
                {
                    filtered.Add(product);
                }
            }

            return filtered;
        }
    }
}
