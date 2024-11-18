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

            Employee employee = new("John Doe", 30, "Developer");
            Console.WriteLine(employee);

            Manager manager = new("Alice smith", 45, "Team lead", "IT");
            Console.WriteLine(manager);
        }
    }
}
