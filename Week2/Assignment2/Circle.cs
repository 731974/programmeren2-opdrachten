using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Circle : Shape
    {

        public Circle(double radius)
        {

            Radius = radius;

        }

        public double Radius { get; set; }

        public override double CalculateArea()
        {

            return Radius * Radius * Math.PI;

        }

        public override string GetShapeInfo()
        {

            return $"Circle area: {this.CalculateArea():f2} \nCircle details: Circle with radius: {Radius}";

        }

    }
}
