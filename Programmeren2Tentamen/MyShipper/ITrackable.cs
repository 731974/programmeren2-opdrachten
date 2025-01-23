using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShipper
{
    public interface ITrackable
    {
        void UpdateStatus(ShippingStatus status);

        string GetTrackingNumber();
    }
}
