using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFSExample
{
    class DFSExample
    {
        static char[,] matrix = LoadMatrix();
        static int counter = 0;
        private static char[,] LoadMatrix()
        {
            string firstLine = Console.ReadLine();
            string[] papaz = firstLine.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(papaz[0]);
            int b = int.Parse(papaz[1]);
            string food = Console.ReadLine();
            string[] foodCoord = food.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = ' ';
                }
            }
            int Fx = int.Parse(foodCoord[0]);
            int Fy = int.Parse(foodCoord[1]);
            matrix[Fx, Fy] = 'E';
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                 string enemies = Console.ReadLine();
                 string[] enemiesCoords = enemies.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                 int g = int.Parse(enemiesCoords[0]);
                 int r = int.Parse(enemiesCoords[1]);
                 matrix[g, r] = 'X';
            }
            return matrix;
        }

        //static void ShowMatrix()
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            Console.Write(matrix[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //}
        

       
    

        static void Main(string[] args)
        {
            
            
            Console.WriteLine(0);
        }
    }
}