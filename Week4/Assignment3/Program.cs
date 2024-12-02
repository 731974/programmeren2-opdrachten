namespace Assignment3
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

            Dictionary<string, Book> books = new Dictionary<string, Book>();

            Book boek1 = new("Jager", "John", "4304390");
            Book boek2 = new("Jager2", "David", "4304391");
            Book boek3 = new("Jager3", "Fred", "4304392");

            books["4304390"] = boek1;
            books["4304391"] = boek2;
            books["4304392"] = boek3;

            DisplayAllBooks(books);

            DisplayBook(books, "4304392");
            DisplayBook(books, "4304389");

        }

        public void DisplayAllBooks(Dictionary<string, Book> books)
        {

            foreach (KeyValuePair<string, Book> book in books)
            {

                Console.WriteLine(book.Value); 

            }

        }

        public void DisplayBook(Dictionary<string, Book> books, string isbn)
        {

            if (books.ContainsKey(isbn))
            {
                Console.WriteLine(books[isbn]);
            } 
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
