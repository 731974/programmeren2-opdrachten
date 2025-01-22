namespace Assignment1
{
    public class Program
    {
        const string FilePath = "../../../user_input.txt";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            WriteToFile(FilePath);
            Console.WriteLine();
            ReadFromFile(FilePath);
        }

        public void WriteToFile(string filePath)
        {
            try
            {
                Console.Write("Enter a text to save to file: ");

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(Console.ReadLine());
                    Console.WriteLine("Data written to file successfully.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadFromFile(string filePath)
        {
            Console.WriteLine("Reading from file:");
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                        Console.WriteLine(reader.ReadLine());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
