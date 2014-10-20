using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Triangle : Shape
    {
        public Triangle(double width, double heigth)
            : base(width, heigth)
        { 
        }
        public override double CalculateSurface()
        {
            return Heigth * (Width / 2);
        }
    }
}
