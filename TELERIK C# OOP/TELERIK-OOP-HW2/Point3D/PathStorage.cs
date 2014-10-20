using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Point3D
{
    class PathStorage
    {
        private const string INPUT_FILE = @"inputFile.txt";
        private const string OUTPUT_FILE = @"outputFile.txt";
     
        public static void SaveFile(Path path)
        {
            StreamWriter writeToFile = new StreamWriter(OUTPUT_FILE);
            using (writeToFile)
            {
                foreach (var point in path.Points)
                {
                   writeToFile.WriteLine(string.Format("{0},{1},{2}", point.x, point.y, point.z));
                }
            }
        }

        public static void LoadPath(Path path)
        {
            StreamReader readFromFile = new StreamReader(INPUT_FILE);
            using (readFromFile)
            {
                while (readFromFile.Peek() >= 0)
	            {
	                string[] temp = readFromFile.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Point3D point = new Point3D(double.Parse(temp[0]), double.Parse(temp[1]), double.Parse(temp[2]));
                    path.AddPoint(point);
	            }                
            }        
        }
    }
}
