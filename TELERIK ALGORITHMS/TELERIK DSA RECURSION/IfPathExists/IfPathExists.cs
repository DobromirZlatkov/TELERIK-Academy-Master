using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPathExists
{
    class IfPathExists
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;

            int[,] emptyLabyrinth = InitEmptyLabyrinth(10, 10);

            SetExit(emptyLabyrinth, 6, 5);
            bool found = false;
            FindExit( row, col, emptyLabyrinth, 0, ref found);
        }

        static void FindExit(int row, int col, int[,] lab, int steps, ref bool found)
        {
            if (row < 0 || row >= lab.GetLength(0) ||
               col < 0 || col >= lab.GetLength(1) || found )
            {
                return;
            }

            if (lab[row, col] == -100)
            {
                found = true;
                PrintMatrix(lab);
                Console.WriteLine("Exit found at [{0},{1}]", row, col);
                return;
            }

            if (lab[row, col] != 0)
            {
                return;
            }


            lab[row, col] = steps;

            FindExit(row - 1, col, lab, steps + 1, ref found);
            FindExit(row, col + 1, lab, steps + 1, ref found);
            FindExit(row + 1, col, lab, steps + 1, ref found);
            FindExit(row, col - 1, lab, steps + 1, ref found);

            lab[row, col] = 0;
        }

        static void SetExit(int[,] labyrinth, int row, int col)
        {
            labyrinth[row, col] = -100;
        }

        static int[,] InitEmptyLabyrinth(int rows, int cols)
        {
            int[,] labyrinth = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    labyrinth[i, j] = 0;
                }
            }

            return labyrinth;
        }

        static void PrintMatrix(int[,] lab)
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j] == -1 || lab[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0,3}", lab[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
