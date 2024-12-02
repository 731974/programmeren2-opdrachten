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

            Dictionary<string, IVehicle> vehicles = new Dictionary<string, IVehicle>();

            Boat boat = new();
            Car car = new Car();

            vehicles.Add("Boat", boat);
            vehicles.Add("Car", car);

            StartAllVehicles(vehicles);
        }

        public void StartAllVehicles(Dictionary<string, IVehicle> vehicles)
        {

            foreach(KeyValuePair<string, IVehicle> entry in vehicles)
            {
                Console.Write($"Starting {entry.Value.GetType().Name}: ");
                entry.Value.Start();
            }
        }
    }
}
