using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Shape
    {



        public abstract double CalculateArea();


        public virtual string GetShapeInfo()
        {
            return "Shape details:";
        }
    }
}
