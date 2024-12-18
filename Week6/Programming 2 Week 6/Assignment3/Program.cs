namespace Assignment3
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
            SaveMultipleEntries("records.txt");
        }

        void ReadEntriesFromFile(string fileName)
        {
            Console.WriteLine("Records saved to file:");

            StreamReader reader = new StreamReader($"../../../{fileName}");

            while (!reader.EndOfStream)
                Console.WriteLine(reader.ReadLine());
        }

        void SaveMultipleEntries(string fileName)
        {
            bool exitIsTrue = false;
            List<string> entries = new List<string>();

            while (!exitIsTrue)
            {
                Console.Write("Enter a name (type 'exit' to stop): ");
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    exitIsTrue = true;
                    break;
                }

                entries.Add(name);
            }

            WriteToFile(entries, fileName);
        }

        void WriteToFile(List<string> entries, string fileName)
        {
            try
            {
                if (!File.Exists($"../../../{fileName}"))
                    throw new IOException();

                StreamWriter writer = new StreamWriter($"../../../{fileName}", true);

                foreach (string entry in entries)
                    writer.WriteLine(entry);

                writer.Close();
                ReadEntriesFromFile("records.txt");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Attempting to save records to file...");
                Console.WriteLine("Error: Unable to save records. Please check file permissions or if the file is in use.");
            }

           
        }
    }
}
