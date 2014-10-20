using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle(10),
                new Rectangle(10, 10),
                new Triangle(10,10)
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} surface = {1}",shape.GetType().ToString(),shape.CalculateSurface());
            }
        }
    }
}
