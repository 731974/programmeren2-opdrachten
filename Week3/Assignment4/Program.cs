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

            Manager manager = new();
            manager.DisplayRole();

            Developer developer = new();
            developer.DisplayRole();

        }
    }
}
