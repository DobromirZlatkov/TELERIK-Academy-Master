using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Task3MDArrays
{
    class Program
    {

        private static int[,] LoadMatrix()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string inputFirstLine = Console.ReadLine();
                string[] input = inputFirstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            
            int[,] matrix = LoadMatrix();
            long result = 0;
            for (int i = 0; i < matrix.GetLength(0) - 4; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {

                    
                       result += CheckForOnes(matrix, i, j); 
                    
                    
                       result += CheckForTwos(matrix, i, j); 
                    
                    
                        result += CheckForThrees(matrix, i, j);
                    
                    
                       result += CheckForFours(matrix, i, j); 
                    
                    
                       result += checkForFives(matrix, i, j); 
                    
                    
                       result += checkForSux(matrix, i, j); 
                    
                    
                       result += checkForSevens(matrix, i, j);  
                    
                    
                       result += checkforEights(matrix, i, j); 
                    
                    
                       result += checkforNines(matrix, i, j);  
                    
                     
                    
                    
                }
            }
            Console.WriteLine(result);
        }

        private static long checkforNines(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i, j] == 9 && matrix[i, j + 1] == 9 && matrix[i, j + 2] == 9)
            {
                if (matrix[i + 1, j + 2] == 9 && matrix[i + 2, j + 2] == 9 && matrix[i + 3, j + 2] == 9 && matrix[i + 4, j + 2] == 9)
                {
                    if (matrix[i + 1, j] == 9 && matrix[i + 2, j + 1] == 9)
                    {
                        if (matrix[i + 4 , j] == 9 && matrix[i + 4, j + 1] == 9)
                        {
                            result += 9;
                        }
                    }
                }
            }
            return result;
        }

        private static long checkforEights(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i, j] == 8 && matrix[i, j + 1] == 8 && matrix[i, j + 2] == 8 )
            {
                if (matrix[i + 2, j + 1] == 8 && matrix[i + 1, j] == 8 && matrix[i + 1, j + 2] == 8)
                {
                    if (matrix[i + 4, j] == 8 && matrix[i+4, j + 1] == 8 && matrix[i+4, j + 2] == 8)
                    {
                        if (matrix[i + 3, j] == 8 &&  matrix[i+3, j + 2] == 8)
                        {
                            result += 8;
                        }
                    }
                }
            }
            return result;
        }

        private static long checkForSevens(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i, j] == 7 && matrix[i, j + 1] == 7 && matrix[i, j + 2] == 7 && matrix[i + 1, j + 2] == 7)
            {
                if (matrix[i + 2, j + 1] == 7 && matrix[i + 3, j + 1] == 7 && matrix[i + 4, j + 1] == 7 )
                {
                    result += 7;
                }
            }
            return result;
        }

        private static long checkForSux(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i,j] == 6 && matrix[i + 1,j] == 6 && matrix[i + 2,j] == 6 && matrix[i + 3,j] == 6 && matrix[i + 4,j] == 6)
            {
                if ( matrix[i + 1, j] == 6 && matrix[i + 2, j] == 6)
                {
                    if (matrix[i + 4, j + 1] == 6 &&  matrix[i + 4, j + 2] == 6)
                    {
                        if (matrix[i+2, j + 1] == 6 && matrix[i + 2, j + 2] == 6 && matrix[i + 3, j + 2] == 6 )
                        {
                            result += 6;
                        }
                    }
                }
            }
            return result;
        }

        private static long checkForFives(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i, j] == 5 && matrix[i + 1, j] == 5 && matrix[i + 2, j] == 5)
            {
                if (matrix[i, j + 1] == 5 && matrix[i, j + 2] == 5)
                {
                    if (matrix[i + 2, j + 1] == 5 && matrix[i + 2, j + 2] == 5 && matrix[i + 3, j + 2] == 5 && matrix[i + 4, j + 2] == 5)
                    {
                        if ( matrix[i + 4, j + 1] == 5 &&  matrix[i + 4, j] == 5)
                        {
                            result += 5;
                        }
                    }
                }
            }
            return result;
        }

        private static long CheckForFours(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i,j] == 4 && matrix[i + 1,j]== 4 && matrix[i + 2, j] == 4)
            {
                if (matrix[i + 1, j + 2] == 4 && matrix[i + 2, j + 2] == 4 && matrix[i + 3, j + 2] == 4 && matrix[i + 4, j + 2] == 4 && matrix[i + 2, j + 1] == 4)
                {
                    result += 4;
                }
            }
            return result;
        }

        private static long CheckForThrees(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i, j] == 3 && matrix[i, j + 1] == 3 && matrix[i, j + 2] == 3)
            {
                if (matrix[i + 1,j + 2] == 3 && matrix[i + 2,j + 2] == 3 && matrix[i + 3,j + 2] == 3 && matrix[i + 4,j + 2] == 3 && matrix[i + 2,j + 1] == 3)
                {
                    if (matrix[i + 4, j] == 3 && matrix[i+4, j + 1] == 3)
                    {
                        result += 3;
                    }
                }
            }
            return result;
        }

        private static long CheckForTwos(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i + 1, j] == 2 && matrix[i,j +1] == 2 && matrix[i + 1, j + 2] == 2 && matrix[i + 2, j + 2] == 2)
            {
                if (matrix[i + 3, j + 1] == 2 && matrix[i + 4, j + 1] == 2 && matrix[i + 4, j] == 2 && matrix[i + 4, j + 2] == 2)
                {
                    result += 2;
                }
            }
            return result;
        }

        private static long CheckForOnes(int[,] matrix, int i, int j)
        {
            long result = 0;
            if (matrix[i + 2,j] == 1 && matrix[i + 1, j + 1] == 1 && matrix[i,j + 2] == 1)
            {
                if (matrix[i + 1, j + 2] == 1 && matrix[i + 2,j + 2] == 1 && matrix[i + 3,j + 2] == 1 && matrix[i + 4,j + 2] == 1)
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}
