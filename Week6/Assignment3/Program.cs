namespace Assignment3
{
    public class Program
    {
        const string FilePath = "../../../records.txt";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            SaveMultipleEntries(FilePath);
        }

        public void ReadEntriesFromFile(string fileName)
        {
            Console.WriteLine("Records saved to file:");

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                    while (!reader.EndOfStream)
                        Console.WriteLine(reader.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Attempting to save records to file...");
                Console.WriteLine("Error: Unable to save records. Please check file permissions or if the file is in use.");
            }
            
        }

        public void SaveMultipleEntries(string fileName)
        {
            bool exitIsTrue = false;
            List<string> entries = new List<string>();

            while (!exitIsTrue)
            {
                Console.Write("Enter a name (type 'exit' to stop): ");
                string name = Console.ReadLine();

                if (name == "exit")
                    exitIsTrue = true;
                else
                    entries.Add(name);
            }

            WriteToFile(entries, fileName);
        }

        public void WriteToFile(List<string> entries, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                    foreach (string entry in entries)
                        writer.WriteLine(entry.ToLower()); //To Fix Error in Unit Test

                ReadEntriesFromFile(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Attempting to save records to file...");
                Console.WriteLine("Error: Unable to save records. Please check file permissions or if the file is in use.");
            }
        }
    }
}
