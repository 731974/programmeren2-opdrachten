namespace Assignment6
{
    internal class Program
    {
        const string FileName = "../../../notes.txt";
        bool wantsToExit = false;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            
            while (!wantsToExit)
                ShowMenu(FileName);

            Console.WriteLine("Exiting program.");
        }

        void ShowMenu(string fileName) 
        {
            try
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Write a note");
                Console.WriteLine("2. View Notes");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                    AddNote(fileName);
                else if (option == 2)
                    ViewNotes(fileName);
                else if (option == 3)
                    wantsToExit = true;
                else
                    Console.WriteLine("Enter a number between 1-3\r\n");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter a valid number.");
            }
        }

        void AddNote(string fileName) {
            Console.Write("Enter your note: ");
            string note = Console.ReadLine();

            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                    sw.WriteLine(note);
            }               
            catch (IOException ex)
            {
                Console.WriteLine($"Error. {ex.Message}");
            }
            Console.WriteLine();
        }

        void ViewNotes(string fileName) {

            try
            {
                Console.WriteLine("Notes:");

                using (StreamReader sr = new StreamReader(fileName))
                    while (!sr.EndOfStream)
                        Console.WriteLine(sr.ReadLine());
            }
            catch (IOException ex) 
            {
                Console.WriteLine($"Error. {ex.Message}");
            }
            Console.WriteLine();
        }
    } 
}
