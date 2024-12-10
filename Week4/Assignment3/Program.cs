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
            AddBookToDictionary(books, new Book("Jager", "John", "4304390"));
            AddBookToDictionary(books,new Book("Jager2", "David", "4304391"));
            AddBookToDictionary(books, new Book("Jager3", "Fred", "4304392"));

            DisplayAllBooks(books);
            DisplayBook(books, "4304392");
            DisplayBook(books, "4304389");
        }

        public void AddBookToDictionary(Dictionary<string, Book> dict, Book book)
        {
            dict.Add(book.ISBN, book);
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