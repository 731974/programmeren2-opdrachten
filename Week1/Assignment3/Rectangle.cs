using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area {
            get
            {
                return Length * Width;
            }
        }
    }
}
