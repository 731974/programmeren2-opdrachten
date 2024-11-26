using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
      
        public override double CalculateArea()
        {
           return Length * Width;
        }

        public override string GetShapeInfo()
        {
            return $"{this.GetType().Name} area: {this.CalculateArea():f2} \n{base.GetShapeInfo()}{this.GetType().Name} with length: {Length}, width: {Width}";
        }
    }
}