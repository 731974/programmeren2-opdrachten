namespace Assignment2
{
    public class Program
    {
        const string PathToFile = "../../../safe_data.txt";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            SafeFileReadWrite(PathToFile);
        }

        public void SafeFileReadWrite(string filePath)
        {
            Console.Write("Enter a text to save to file: ");

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                    writer.Write(Console.ReadLine());
                    Console.WriteLine("Data written successfully.\r\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Unable to write to file.");
            }

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("Reading file content:");
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Unable to read from file.");
            }
        }
    }
}
