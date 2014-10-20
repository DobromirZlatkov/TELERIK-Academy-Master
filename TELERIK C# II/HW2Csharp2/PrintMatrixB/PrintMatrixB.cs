using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixB
{
    class PrintMatrixB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int number = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (col % 2 == 0)
                {                 
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }               
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
