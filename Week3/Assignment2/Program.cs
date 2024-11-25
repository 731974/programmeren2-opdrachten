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
            // This start code will help you in hinting in how to structure your fulltime and parttime employee classes

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(5000);
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(20, 160);

            Console.WriteLine($"Full time employee salary: {fullTimeEmployee.GetSalary()}");
            Console.WriteLine($"Part time employee salary: {partTimeEmployee.GetSalary()}");
        }
    }
}
