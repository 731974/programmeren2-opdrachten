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
            vehicles.Add("Boat", new Boat());
            vehicles.Add("Car", new Car());
            StartAllVehicles(vehicles);
        }

        public void StartAllVehicles(Dictionary<string, IVehicle> vehicles)
        {
            foreach (KeyValuePair<string, IVehicle> vehicle in vehicles)
            {
                Console.Write($"Starting {vehicle.Key}: ");
                vehicle.Value.Start();
            }
        }
    }
}