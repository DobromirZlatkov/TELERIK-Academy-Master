using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Shape
    {
        private double width;
        private double heigth;
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Heigth
        {
            get { return this.heigth; }
            set { this.heigth = value; }
        }
        public Shape(double width)
        {
            this.Width = width;
        }
        public Shape(double width, double heigth)
            :this(width)
        {           
            this.Heigth = heigth;
        }

        public abstract double CalculateSurface();
    }
}
