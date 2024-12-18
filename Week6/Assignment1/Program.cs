namespace Assignment1
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
            Console.Write("Enter a text to save to file: ");
            string userInput = Console.ReadLine();

            WriteToFile(userInput);
            Console.WriteLine();
            ReadFromFile("../../../user_input.txt");
        }

        void WriteToFile(string userInput)
        {

            try
            {
                StreamWriter writer = new StreamWriter("../../../user_input.txt");
                writer.WriteLine(userInput);
                Console.WriteLine("Data written to file successfully.");
                writer.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void ReadFromFile(string fileName)
        {
            Console.WriteLine("Reading from file:");
            try
            {
                StreamReader reader = reader = new StreamReader(fileName);
                reader.Close();
                Console.WriteLine(reader.ReadLine());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }
}
