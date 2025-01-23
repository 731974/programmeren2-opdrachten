using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShipper
{
    public class PriorityPackage : Package
    {
        public double FlatFee { get; }
        public PriorityPackage(string trackingNumber, string recipient, string address, string postalCode) : base(trackingNumber, recipient, address, postalCode)
        {
            FlatFee = 29.99;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"[Priority Package] Tracking: {TrackingNumber}, Recipient: {Recipient}, Address: {Address}, Postal Code: {PostalCode}, Flat Fee: ${FlatFee}, Status: {Status}");
        }

        public override double CalculateShippingCost()
        {
            return FlatFee;
        }

    }
}
