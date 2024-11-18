using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdr1
{
    public class Vehicle
    {

        public Vehicle(double fuelCapacity, int topSpeed)
        {
            this.fuelCapacity = fuelCapacity;
            this.topSpeed = topSpeed;
        }

        private double fuelCapacity { get; set; }
        private int topSpeed { get; set; }
        
        public virtual double CalculateFuelConsumption(int currentSpeed, double FuelEfficienfy)
        {
            return currentSpeed * FuelEfficienfy;
        }
    }
}
