using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBIt_second
{
    class FormulaBIt
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    int bit = (number >> j) & 1;
                    if (bit == 1)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            string direction = "down";
            int row = 0;
            int col = 0;
            string lastDirection = "down";
            int pathCount = 0;
            int directionChange = 0;
            while (true)
            {     


                pathCount++;
               
                if (direction == "down")
                {
                    row++;
                }
                else if (direction == "right")
                {
                    col++;
                }
                else if (direction == "up")
                {
                    row--;
                }

                

                if (direction == "down" && (matrix[row,col] == 1 || row > 7))
                {
                    lastDirection = "down";
                    row--;
                    direction = "right";
                    directionChange++;
                }
                else if (direction == "right" && matrix[row,col] == 1 && lastDirection == "down")
                {
                    col--;
                    direction = "up";
                    directionChange++;
                }
                else if (direction == "right" && matrix[row,col] == 1 && lastDirection == "up")
                {
                    col--;
                    direction = "down";
                    directionChange++;
                }
                else if (direction == "up" && matrix[row, col] == 1)
                {
                    lastDirection = "up";
                    row++;
                    direction = "right";
                    directionChange++;
                }            
            }
        }
    }
}
