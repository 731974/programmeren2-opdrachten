namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            AskNumber();
        }

        public int AskNumber()
        {
            int number = 0;

            try
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine($"The entered number is {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input. Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("AskNumber execution completed.");
            }

            return number;
        }
    }
}
