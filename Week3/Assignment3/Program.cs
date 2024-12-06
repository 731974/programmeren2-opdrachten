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
            // This start code will help you in hinting in how to structure your contractor clas
            Contractor contractor = new Contractor(50, 100);
            contractor.Work();
            Console.WriteLine($"Contractor payment: {contractor.GetPayment()}");
        }
    }
}
