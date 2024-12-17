namespace Assignment3
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
            try
            {
                Console.Write("Enter a number: ");
                Console.WriteLine($"The square root of 5 is: {CalculateSquareRoot(double.Parse(Console.ReadLine()))}");
            }
            catch (NegativeValueException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public double CalculateSquareRoot(double number)
        {
            if (number < 0)
                throw new NegativeValueException("Error: Negative values are not allowed.");
            else
                return (double)Math.Pow(number, 2);
        }
    }
}
