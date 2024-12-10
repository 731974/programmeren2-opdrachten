namespace Assignment5to7
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
            Dictionary<string, LibraryItem> library = new Dictionary<string, LibraryItem>();

            library.Add("3490349032", new Book("Jager1", "Jan", "3490349032"));
            library.Add("3490349033", new Book("Jager5", "Dirk", "3490349033"));
            library.Add("3490349034", new Book("Jager7", "Peter", "3490349034"));
            library.Add("3490349035", new Magazine("Jager7", "Peter", "3490349035"));
            library.Add("3490349036", new Magazine("Jager4", "Veter", "3490349036"));
            library.Add("3490349037", new Magazine("Jager2", "Polp", "3490349037"));

            DisplayAllLibraryItems(library);
        }

        public void DisplayAllLibraryItems(Dictionary<string, LibraryItem> libraryItems)
        {
            foreach (KeyValuePair<string, LibraryItem> item in libraryItems) {
                Console.WriteLine(item.Value);    
            }
        }

        public void BorrowLibraryItem(Dictionary<string, LibraryItem> library, string isbn, Person person, DateTime dueDate)
        {
            LibraryItem item = library[isbn];
            BorrowingManager borrowingManager = new BorrowingManager();
            borrowingManager.BorrowItem(item, person, dueDate);
        }
    }
}