using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShipper
{
    public class StandardPackage : Package
    {

        public double Weight { get; private set; }
        public double CostPerKg { get; private set; }

        public StandardPackage(string trackingNumber, string recipient, string address, string postalCode, double weight) : base(trackingNumber, recipient, address, postalCode)
        {
            Weight = weight;
            CostPerKg = 2.5;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Standard Package] Tracking: {TrackingNumber}, Recipient: {Recipient}, Address: {Address}, Postal Code: {PostalCode}, Weight: {Weight}, Status: {Status}");
        }

        public override double CalculateShippingCost()
        {
            return Weight * CostPerKg;
        }
    }
}
