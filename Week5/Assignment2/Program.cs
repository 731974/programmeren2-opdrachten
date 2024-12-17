namespace Assignment2
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
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                ValidateAge(age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: Age must be 18 or older to proceed.");
            }
        }

        public void ValidateAge(int age)
        {
            if (age < 18)
                throw new ArgumentException("Error: Age must be 18 or older to proceed. ");
            else
                Console.WriteLine("Proceeding...");
        }
    }
}
