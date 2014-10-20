using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    struct Point3D
    {
        //task 1
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        // task2
        public static readonly Point3D point0 = new Point3D(0, 0, 0);
        //task 1
        public Point3D(double x, double y, double z)
            : this() 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        // task2
        public Point3D Point0
        {
            get { return point0; }
        }
        //task 1
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("X:" + this.x + " || ");
            sb.Append("Y:" + this.y + " || ");
            sb.Append("Z:" + this.z);
            return sb.ToString();
        }
    }
}
