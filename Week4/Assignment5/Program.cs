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

            Book boek0 = new("Jager1", "Jan", "3490349032");
            Book boek1 = new("Jager5", "Dirk", "3490349033");
            Book boek2 = new("Jager7", "Peter", "3490349034");

            Magazine magazine0 = new("Jager7", "Peter", "3490349035");
            Magazine magazine1 = new("Jager4", "Veter", "3490349036");
            Magazine magazine2 = new("Jager2", "Polp", "3490349037");

            library.Add("3490349032", boek0);
            library.Add("3490349033", boek1);
            library.Add("3490349034", boek2);

            library.Add("3490349035", magazine0);
            library.Add("3490349036", magazine1);
            library.Add("3490349037", magazine2);

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
