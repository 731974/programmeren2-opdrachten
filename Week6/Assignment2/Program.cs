namespace Assignment2
{
    internal class Program
    {
        const string PathToFile = "../../../safe_data.txt";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            Console.Write("Enter a text to save to file: ");
            string userInput = Console.ReadLine();
            SafeFileReadWrite(userInput);

        }

        void SafeFileReadWrite(string userInput)
        {
            try
            {
                StreamWriter writer = new StreamWriter(PathToFile);
                writer.Write(userInput);
                writer.Close();
                Console.WriteLine("Data written successfully.\r\n");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: Unable to write to file.");
            }


            try
            {
                StreamReader reader = new StreamReader(PathToFile);
                Console.WriteLine("Reading file content:");
                Console.WriteLine(reader.ReadLine());
                reader.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: Unable to read from file.");
            }
        }
    }
}
