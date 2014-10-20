using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    //task 4
    class Path
    {
        public List<Point3D> points;
       
        public List<Point3D> Points
        {
            get
            {
                return new List<Point3D>(this.points);
            }
        }

        public Path()
        {
            this.points = new List<Point3D>();
        }
       
        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void PrintPath()
        {
            foreach (var point in this.points)
            {
                Console.WriteLine(point.ToString());
            }
        }

        
    }
}
