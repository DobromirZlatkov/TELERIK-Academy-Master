using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {

        private static int[,] LoadMatrix()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] lqlq = input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(lqlq[j]);
                }
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            int[,] matrix = LoadMatrix();            
            FIndPattern(matrix);                       
        }

        private static void FIndPattern(int[,] matrix)
        {
            int sum = int.MinValue;
            int result = 0;
            bool isAPatternThere = false;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 4; col++)
                {

                    if (matrix[row,col] == matrix[row,col+1] - 1)
                    {
                        if (matrix[row,col+1] == matrix[row,col+2] - 1)
                        {
                            if (matrix[row,col+2] == matrix[row + 1,col+2] - 1)
                            {
                                if ( matrix[row + 1,col+2] ==  matrix[row + 2,col+2] - 1)
                                {
                                    if (matrix[row + 2,col+2] == matrix[row + 2,col+3] - 1)
                                    {
                                        if (matrix[row + 2,col+3] == matrix[row + 2,col+4] - 1)
                                        {
                                            result = matrix[row, col] + matrix[row, col + 1] +
                                                matrix[row, col + 2] + matrix[row + 1, col + 2] +
                                                matrix[row + 2, col + 2] + matrix[row + 2, col + 3] +
                                                matrix[row + 2, col + 4];
                                            isAPatternThere = true;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    
                }
                if (sum < result)
                {
                    sum = result;
                }
            }

            if (isAPatternThere)
            {
                Console.WriteLine("YES " + sum);
            }
            else
            {
                int diagonalSUm = FIndDiagonalSUm(matrix);
                Console.WriteLine("NO " + diagonalSUm);
            }            
        }

        private static int FIndDiagonalSUm(int[,] matrix)
        {
            int result = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += matrix[i, i];
            }
            return result;
        }                
    }
}
