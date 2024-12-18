namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            SearchInFile("../../../records.txt");
        }

        void SearchInFile(string fileName) 
        {
            Console.Write("Enter a name to search: ");
            string nameToSearch = Console.ReadLine();
            bool nameFound = false;

            StreamReader reader = new StreamReader(fileName);

            while (!reader.EndOfStream) 
                if (reader.ReadLine().ToLower() == nameToSearch.ToLower())
                    nameFound = true;

            string response = (nameFound) ? "Name found." : "Name not found.";
            Console.WriteLine(response);
        }
    }
}
