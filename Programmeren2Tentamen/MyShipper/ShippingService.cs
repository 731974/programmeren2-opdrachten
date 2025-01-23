using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShipper
{
    public class ShippingService
    {

        List<Package> packages;
        Dictionary<string, Package> packageByTrackingNumber  = new Dictionary<string, Package>();
        Log log;

        public ShippingService()
        {
            packages = new List<Package>();
            log = new Log();
        }

        public void AddPackage(Package package)
        {
            try
            {
                if (packageByTrackingNumber.ContainsKey(package.TrackingNumber))
                    throw new Exception($"Can not add package: {package.TrackingNumber}. It is already being tracked.");
                
                packageByTrackingNumber.Add(package.TrackingNumber, package);
                packages.Add(package);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }
        }

        public List<Package> GetPackagesByStatus(ShippingStatus status)
        {
            List<Package> p = new List<Package>();

            foreach(Package package in packages)
                if (package.Status == status)
                    p.Add(package);

            return p;
        }

        public double GetTotalValueOfPackages()
        {
            double totalValueOfPackages = 0;

            foreach (Package package in packages)
                totalValueOfPackages += package.CalculateShippingCost();

            return totalValueOfPackages;
        }

        public Package GetPackageByTrackingNumber(string number)
        {
            foreach (Package package in packages)
                if (package.TrackingNumber == number)
                    return package;

            throw new PackageNotFoundException($"Package with tracking number {number} not found");
        }

        public void UpdatePackageStatus(string trackingNumber, ShippingStatus status)
        {
            try
            {
                Package package = GetPackageByTrackingNumber(trackingNumber);

                package.UpdateStatus(status);

                if (status == ShippingStatus.Delivered)
                    log.Success($"Package {trackingNumber} delivered");
            }
            catch (PackageNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }
        }

        public void DisplayPackagesReport()
        {
            Console.WriteLine("PACKAGES REPORT:");
            Console.WriteLine($"Total number of packages: {packages.Count}");
            Console.WriteLine($"Total value of packages: {GetTotalValueOfPackages():f2}\n");

            Console.WriteLine("Pending packages:");
            DisplayPackagesFromList(GetPackagesByStatus(ShippingStatus.Pending));
            Console.WriteLine();

            Console.WriteLine("En route packages:");
            DisplayPackagesFromList(GetPackagesByStatus(ShippingStatus.EnRoute));
            Console.WriteLine();

            Console.WriteLine("Delivered packages:");
            DisplayPackagesFromList(GetPackagesByStatus(ShippingStatus.Delivered));
        }

        void DisplayPackagesFromList(List<Package> packages)
        {
            foreach (Package package in packages)
                package.DisplayDetails();
        }   
    }
}
