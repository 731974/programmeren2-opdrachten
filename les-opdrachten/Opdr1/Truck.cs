using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdr1
{
    public class Truck : Vehicle
    {

        public Truck(double cargoCapacity, double fuelCapacity, int topSpeed) : base (fuelCapacity, topSpeed)
        {
            this.cargoCapacity = cargoCapacity;
        }

        public override double CalculateFuelConsumption(int currentSpeed, double FuelEfficienfy)
        {
            return base.CalculateFuelConsumption(currentSpeed, FuelEfficienfy*2);
        }

        private double cargoCapacity { get; set; }
    }
}
