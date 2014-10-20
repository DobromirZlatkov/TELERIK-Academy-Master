using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Point3D point = Point3D.point0;
           
            Console.WriteLine(point.ToString());
            
            Point3D secondPoint = new Point3D(3, 4, 7);

            Console.WriteLine(secondPoint.ToString());

            Console.WriteLine(Distance.DistanceBetween3DPoints(point, secondPoint));
           
            Path newPath = new Path();

            PathStorage.LoadPath(newPath);
           
            PathStorage.SaveFile(newPath);
            
        }
    }
}
