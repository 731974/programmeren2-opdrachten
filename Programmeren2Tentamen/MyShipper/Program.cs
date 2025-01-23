namespace MyShipper
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
            // OPDR 1
            //List<Package> trackables = new List<Package>();
            //trackables.Add(new StandardPackage("123456789", "Joe Smith", "123 A. st", "2012AB", 5.5));
            //trackables.Add(new StandardPackage("234567891", "Jane Smith", "124 A. st", "2013AB", 10.5));
            //trackables.Add(new PriorityPackage("345678912", "Bob Smith", "125 A. st", "2014AB"));
            //trackables.Add(new PriorityPackage("456789123", "Fred Smith", "126 A. st", "2015AB"));
            //DisplayDetailsForAllPackages(trackables);

            // OPDR 2
            ShippingService service = new ShippingService();
            service.AddPackage(new StandardPackage("123456789", "Joe Smith", "123 A. st", "2012AB", 5.5));
            service.AddPackage(new StandardPackage("234567891", "Jane Smith", "124 A. st", "2013AB", 10.5));
            service.AddPackage(new PriorityPackage("345678912", "Bob Smith", "125 A. st", "2014AB"));
            service.AddPackage(new PriorityPackage("456789123", "Fred Smith", "126 A. st", "2015AB"));

            service.UpdatePackageStatus("456789123", ShippingStatus.Delivered);
            service.UpdatePackageStatus("234567891", ShippingStatus.EnRoute);

            service.DisplayPackagesReport();

            //OPDR 3
            Console.WriteLine();
            service.UpdatePackageStatus("9999999999", ShippingStatus.Pending);
            service.AddPackage(new StandardPackage("234567891", "Jane Smith", "124 A. st", "2013AB", 10.5));

        }

        void DisplayDetailsForAllPackages(List<Package> list)
        {
            foreach (Package trackable in list)
                trackable.DisplayDetails();
        }
    }
}
