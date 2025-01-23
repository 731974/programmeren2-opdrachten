using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShipper
{
    public abstract class Package : ITrackable
    {
        public string TrackingNumber { get; private set; }
        public string Recipient { get; private set; }
        public string Address { get; private set; }
        public string PostalCode { get; private set; }  
        public ShippingStatus Status { get; private set; }

        public Package(string trackingNumber, string recipient, string address, string postalCode)
        {
            TrackingNumber = trackingNumber;
            Recipient = recipient;
            Address = address;
            PostalCode = postalCode;
            Status = ShippingStatus.Pending;
        }

        public abstract void DisplayDetails();
        public abstract double CalculateShippingCost();

        public void UpdateStatus(ShippingStatus status)
        {
            Status = status;
        }

        public string GetTrackingNumber()
        {
            return TrackingNumber;
        }
    }
}
