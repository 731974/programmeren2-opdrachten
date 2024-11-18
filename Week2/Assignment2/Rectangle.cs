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

        public Rectangle(double length, double width)
        {

            Length = length;
            Width = width;

        }

        public double Length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {

           return Length * Width;

        }

        public override string GetShapeInfo()
        {

         return $"Rectangle area: {this.CalculateArea():f2} \nRectangle details: Rectangle with length: {Length}, width: {Width}"; 

        }


    }
}
