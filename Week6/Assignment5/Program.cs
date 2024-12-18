namespace Assignment5
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

            try
            {
                StreamReader reader = new StreamReader("../../../doc.txt");
                while (!reader.EndOfStream)
                    Console.WriteLine(reader.ReadLine);
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                LogFileErrors("Error: File not Found ", "log.txt");
            }

            try
            {
                StreamReader reader = new StreamReader("../../../../doc.txt");
                while (!reader.EndOfStream)
                    Console.WriteLine(reader.ReadLine);
            }
            catch (DirectoryNotFoundException e)
            {
                LogFileErrors("Error: Directory not Found ", "log.txt");
            }
            catch (FileNotFoundException e)
            {
                LogFileErrors("Error: File not Found ", "log.txt");
            }

            try
            {
                StreamReader reader = new StreamReader("../../../test.txt");
                while (!reader.EndOfStream)
                    Console.WriteLine(reader.ReadLine);

                StreamWriter writer = new StreamWriter("../../../test.txt");
                writer.WriteLine("Some extra data");
                writer.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                LogFileErrors("Error: Invalid operation ", "log.txt");
            }

            ReadAllLogErrors("log.txt");
        }

        void ReadAllLogErrors(string fileName)
        {
            StreamReader reader = new StreamReader($"../../../{fileName}");

            while (!reader.EndOfStream)
                Console.WriteLine(reader.ReadLine());
        }

        void LogFileErrors(string exception, string fileName)
        {
            StreamWriter writer = new StreamWriter($"../../../{fileName}", true);
            writer.WriteLine(exception);
            writer.Close();
        }
    }
}
