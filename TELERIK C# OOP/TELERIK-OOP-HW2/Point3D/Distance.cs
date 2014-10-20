using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    //task 3
    class Distance
    {

        public static double DistanceBetween3DPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double distanceX = firstPoint.x - secondPoint.x;
            double distanceY = firstPoint.y - secondPoint.y;
            double distanceZ = firstPoint.z - secondPoint.z;

            distanceX = Math.Pow(distanceX, 2);
            distanceY = Math.Pow(distanceY, 2);
            distanceZ = Math.Pow(distanceZ, 2);

            double result = Math.Sqrt(distanceX + distanceY + distanceZ);

            return result;                    
        }
    }
}
