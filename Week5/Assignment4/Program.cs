namespace Assignment4
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
            TryDivision();
        }


        public void TryDivision()
        {
            try
            {
                Console.Write("Enter the first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                int result = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (DivideByZeroException zeroEx)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            finally
            {
                Console.Write("Do you wish to continue (y/n): ");

                if (char.Parse(Console.ReadLine().ToLower()) == 'y')
                    TryDivision();
            }
        }
    }
}