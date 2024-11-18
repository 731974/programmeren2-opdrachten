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

            Vehicle vehicle = new();
            vehicle.StartEngine();
            ElectricCar electricCar = new();
            electricCar.StartEngine();
            DieselCar dieselCar = new();
            dieselCar.StartEngine();

        }
    }
}
