using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Tests
    {

        static void Main(string[] args)
        {

            Matrix<double> firstMatrix = new Matrix<double>(5, 5);
            firstMatrix = LoadMatrix(5);
            Matrix<double> secondmatrix = new Matrix<double>(5, 5);
            secondmatrix = LoadMatrix(6);
            Matrix<double> result = firstMatrix - secondmatrix;

            secondmatrix[0, 1] = 0;

            Console.WriteLine(firstMatrix.ToString());

            Console.WriteLine(secondmatrix.ToString());

            Console.WriteLine(result.ToString());
            if (secondmatrix)
            {
                Console.WriteLine("No zero inside");
            }
            else
            {
                Console.WriteLine("There is zero inside");            
            }            
        }

        public static Matrix<double> LoadMatrix(int p)
        {
            Matrix<double> firstMatrix = new Matrix<double>(5, 5);
            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    firstMatrix[i, j] = p;
                }
            }
            return firstMatrix;
        }

  

       
    }
}
