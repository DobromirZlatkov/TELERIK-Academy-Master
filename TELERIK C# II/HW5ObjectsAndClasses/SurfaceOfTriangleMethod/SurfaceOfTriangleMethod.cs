using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceOfTriangleMethod
{
    class SurfaceOfTriangleMethod
    {
        static void Main(string[] args)
        {            
            double firstSide = 5;
            double secondSide = 6;
            double thirdSide = 7;
            double angle = 90;
            double height = 6;

            Console.WriteLine("S = {0}", BySideAndAltitute(firstSide, height));
            Console.WriteLine("S = {0}", ByThreeSides(firstSide, secondSide, thirdSide));
            Console.WriteLine("S = {0}", ByTwoSidesAndAngle(firstSide, secondSide, angle));
        }
        private static double ByTwoSidesAndAngle(double firstSide, double secondSide, double angle)
        {
            angle = Math.PI * angle / 180;
            double S = (firstSide * secondSide * Math.Sin(angle)) / 2;
            return S;
        }        
        private static double ByThreeSides(double firstSide, double secondSide, double thirdSide)
        {
            double semi = (firstSide + secondSide + thirdSide) / 2;

            double S = Math.Sqrt(semi * (semi - firstSide) * (semi - secondSide) * (semi - thirdSide));
            return S;
        }        
        private static double BySideAndAltitute(double firstSide, double height)
        {
            return (firstSide * height) / 2;
        }
    }
}
