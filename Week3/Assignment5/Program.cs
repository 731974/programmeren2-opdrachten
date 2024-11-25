namespace Assignment5to7
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
            // Code to "Functionally" test assignment 5
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("John Doe", "Developer", 5000);
            //fullTimeEmployee.DisplayDetails();
            //Console.WriteLine();
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Jane Smith", "Designer", 30, 150);
            //partTimeEmployee.DisplayDetails();

            // Code to "Functionally" test assignment 6
            //IEmployeeOperations[] employees = new IEmployeeOperations[2];
            //employees[0] = new FullTimeEmployee("John Doe", "Developer", 5000);
            //employees[1] = new PartTimeEmployee("Jane Smith", "Designer", 30, 150);

            //foreach (IEmployeeOperations employee in employees)
            //{
            //    employee.DisplayDetails();
            //    Console.WriteLine();
            //}

            // Code to "Functionally" test assignment 7
            IReportable[] reportables = new IReportable[2];
            reportables[0] = new FullTimeEmployee("John Doe", "Developer", 5000);
            reportables[1] = new PartTimeEmployee("Jane Smith", "Designer", 30, 150);

            foreach (IReportable reportable in reportables)
            {
                reportable.GenerateReport();
                Console.WriteLine();
            }
        }
    }
}
