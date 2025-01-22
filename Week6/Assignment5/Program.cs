namespace Assignment5
{
    public class Program
    {
        const string PathToLog = "../../../log.txt";

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            try
            {
                using (StreamReader sr = new StreamReader("../../test.txt"))
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                LogFileErrors(new FileNotFoundException("File not found"), PathToLog);
            }

        }

        void ReadAllLogErrors(string fileName)
        {
            StreamReader reader = new StreamReader($"../../../{fileName}");

            while (!reader.EndOfStream)
                Console.WriteLine(reader.ReadLine());
        }

      public void LogFileErrors(Exception ex, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine($"Error: {ex.Message}");
            writer.Close();
        }

    }
}
