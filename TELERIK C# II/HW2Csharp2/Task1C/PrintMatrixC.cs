using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixC
{
    class PrintMatrixC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int numbers = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[(n - i + j - 1), j] = numbers;
                    numbers++;
                }
            }           
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0 ; j--)
                {
                    matrix[i - j, n - j - 1] = numbers;
                    numbers++;
                }
            }
            PrintsMatrix(matrix);
        }

        private static void PrintsMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
