using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override string GetShapeInfo()
        {
            return  $"{this.GetType().Name} area: {this.CalculateArea():f2} \n{base.GetShapeInfo()}{this.GetType().Name} with radius: {Radius}";
        }
    }
}