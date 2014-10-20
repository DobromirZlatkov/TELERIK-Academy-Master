using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularMatrix
{
    class RectangularMatrix
    {
        static void Main(string[] args)
        {

            /*Write a program that reads a rectangular matrix of size N x M 
             * and finds in it the square 3 x 3 that has maximal sum of its
             * elements.
            */
            Console.WriteLine("Enter N and M");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            int bestSum = int.MinValue;

            Console.WriteLine("Fill the matrix");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Matrix looks like");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}",matrix[i,j]);
                }
                Console.WriteLine();
            }


            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 2, col] + 
                              matrix[row + 1, col + 1] + matrix[row + 2, col + 2] +
                              matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }

                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Best sum = {0}", bestSum);
            
        }
    }
}
