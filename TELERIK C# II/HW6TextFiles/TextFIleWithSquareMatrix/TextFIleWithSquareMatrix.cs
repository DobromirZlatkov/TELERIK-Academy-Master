using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFIleWithSquareMatrix
{
    class TextFIleWithSquareMatrix
    {
        /*Write a program that reads a text file containing a 
         * square matrix of numbers and finds in the matrix 
         * an area of size 2 x 2 with a maximal sum of its 
         * elements. The first line in the input file contains 
         * the size of matrix N. Each of the next N lines contain
         * N numbers separated by space. The output should be
         * a single number in a separate text file. Example:
        */
        // all text files are in directory where is .cs
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N size of the matrix");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = FIllMatrix(n);

            PrintMatrixToFile(matrix);

            int[,] newMatrix = TakeMatrixFromText(n);
           
            PutResultInText(GetMaxSum(newMatrix));           
        }

        private static void PutResultInText(int p)
        {
            StreamWriter writer = new StreamWriter("result.txt");
            using (writer)
            {
                writer.WriteLine(p);
            }

            StreamReader reader = new StreamReader("result.txt");
            using (reader)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }

        private static int GetMaxSum(int[,] newMatrix)
        {
            int sum = 0;
            int result = 0;
            for (int i = 0; i < newMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1) - 1; j++)
                {                                       
                    sum = newMatrix[i, j] + newMatrix[i, j + 1] + 
                        newMatrix[i + 1, j] + newMatrix[i + 1, j + 1];
                    if (sum > result)
                    {
                        result = sum;
                    }
                }
                

            }
            return result;
        }

        private static int[,] TakeMatrixFromText(int n)
        {
            int[,] newMatrix = new int[n, n];
            StreamReader reader = new StreamReader("matrixText.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                for (int i = 0; i < newMatrix.GetLength(0); i++)
                {
                    string[] numbers = line.Split();
                    for (int j = 0; j < newMatrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] = Convert.ToInt32(numbers[j]);
                    }
                    line = reader.ReadLine();
                }
            }
            return newMatrix;
        }

        private static void PrintMatrixToFile(int[,] matrix)
        {
            StreamWriter matrixWriter = new StreamWriter("matrixText.txt");
            using (matrixWriter)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrixWriter.Write(matrix[i, j] + " ");
                    }
                    matrixWriter.WriteLine();
                }
            }
        }

        private static int[,] FIllMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            Console.WriteLine("Enter Numbers of the matrix separated by space");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] lineNumbers = Console.ReadLine().Split();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(lineNumbers[j]);
                }
            }
            return matrix;
        }
    }
}
