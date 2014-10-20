using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPathsInMatrix
{
    class AllPathsInMatrix
    {
        static int[,] lab = 
                    {
                    {0, 0, 0, -1, 0, 0, 0},
                    {-1, -1, 0, -1, 0, -1, 0},
                    {0, 0, 0, 0, 0, 0, 0},
                    {0, -1, -1, -1,-1, -1, 0},
                    {0, 0, 0, 0, 0, 0, 100},
                    };

        static void Main(string[] args)
        {
            FindPath(0, 0, lab);
        }

        private static void FindPath(int startX, int startY, int[,] lab)
        {
            FindExit(startX, startY, lab, 1);
        }

        private static void FindExit(int row, int col, int[,] lab, int steps)
        {
            if (row < 0 || row >= lab.GetLength(0) || 
                col < 0 || col >= lab.GetLength(1))
            {
                return;
            }

            if (lab[row, col] == 100)
            {
                Console.WriteLine(steps - 1);
                PrintMatrix(lab);
                return;
            }


            if (lab[row, col] != 0)
            {
                return;
            }


            lab[row, col] = steps;

            FindExit(row - 1, col, lab, steps + 1);
            FindExit(row , col + 1, lab, steps + 1);
            FindExit(row + 1, col, lab, steps + 1);
            FindExit(row, col - 1, lab, steps + 1);

            lab[row, col] = 0;
        }

        static void PrintMatrix(int[,] lab)
        {
          //  Console.Clear();
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
                    Console.Write("{0,5}", lab[i,j]);
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
