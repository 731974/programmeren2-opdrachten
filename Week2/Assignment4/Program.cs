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

            FullTimeEmployee fullTimeEmployee = new("John Doe", 50000);
            fullTimeEmployee.DisplayEmployeeDetails();

            PartTimeEmployee partTimeEmployee = new("Jane Smith", 50000);
            partTimeEmployee.DisplayEmployeeDetails();



        }
    }
}
