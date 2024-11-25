namespace Assignment1
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

            Bike bike = new();
            bike.Drive();

            Car car = new();
            car.Drive();

        }
    }
}
