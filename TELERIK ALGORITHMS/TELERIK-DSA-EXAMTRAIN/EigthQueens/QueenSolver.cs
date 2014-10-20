using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EigthQueens
{
    class QueenSolver
    {
        byte[,] queens;

        private int counter = 0;

        public QueenSolver(int size)
        {
            this.queens = new byte[size, size];
        }

        internal int FindAllSolutions()
        {
            Recursion(0);
            return this.counter;
        }

        private void Recursion(int row)
        {
            if (row == this.queens.GetLength(1))
            {
                this.counter++;
                return;
            }

            for (int col = 0; col < this.queens.GetLength(0); col++)
            {
                if (this.queens[row,col] == 0)
                {
                    this.queens[row, col] += 1;
                    MarkQueen(row, col);

                    Recursion(row + 1);
                    
                    this.queens[row, col] -= 1;
                    UnMarkQueen(row, col);
                    
                }
            }
        }

        private void Print()
        {
            for (int i = 0; i < this.queens.GetLength(0); i++)
            {
                for (int j = 0; j < this.queens.GetLength(1); j++)
                {
                    Console.Write("{0, 3}", queens[i,j]);
                }
                Console.WriteLine();
            }
        }


        private void UnMarkQueen(int row, int col)
        {
            for (int i = row; i < this.queens.GetLength(0); i++)
            {
                this.queens[i, col] -= 1;
                if (col + (i - row) < this.queens.GetLength(0))
                {
                    this.queens[i, col + (i - row)] -= 1;
                }
                if (col - (i - row) >= 0)
                {
                    this.queens[i, col - (i - row)] -= 1;
                }
            }
        }

        private void MarkQueen(int row, int col)
        {
            for (int i = row; i < this.queens.GetLength(0); i++)
            {
                this.queens[i, col] += 1;
                if (col + (i - row) < this.queens.GetLength(0))
                {
                    this.queens[i, col + (i - row)] += 1;
                }
                if (col - (i - row) >= 0)
                {
                    this.queens[i, col - (i - row)] += 1; 
                }
            }
        }
    }
}
