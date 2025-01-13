using System.Collections;

namespace Lists
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

            // Method 1

            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            //numbers.Add("four"); //No compile errors

            foreach (int i in numbers)
                Console.WriteLine(i); //Will result in a run-time error "four" != integer

            //QUICK FIX would be replacing int with var, but that is not a very good way to fix it. 

            Console.WriteLine(numbers.Count);

            // Method 2

            List<int> stronglyTypedList = new List<int>(); 

            // Verschil is dat dit alleen integers neemt, als je dan een "four" toevoegt, krijg je een compile error.
            // Dit is een betere manier.

            stronglyTypedList.Add(1);
            stronglyTypedList.Add(20);

            int strongCount = stronglyTypedList.Count();
            Console.WriteLine(strongCount); // Their is no .Lenght attribute, but a count attribute or count function .Count == .Count()


        }
    }
}
