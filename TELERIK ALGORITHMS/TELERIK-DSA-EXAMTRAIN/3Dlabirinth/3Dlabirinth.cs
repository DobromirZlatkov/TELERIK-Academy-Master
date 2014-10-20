using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _3Dlabirinth
{
    class Cell
    {
        public Cell(int heigth, int row, int col, int qlevel)
        {
            this.Heigth = heigth;
            this.Row = row;
            this.Col = col;
            this.Queuelevel = qlevel;
        }

        public int Heigth { get; set; }
               
        public int Row { get; set; }
               
        public int Col { get; set; }

        public int Queuelevel { get; set; }

        public override bool Equals(object obj)
        {
            var otherCell = obj as Cell;
            if (otherCell == null)
            {
                return false;
            }

            return this.Heigth.Equals(otherCell.Heigth) &&
                   this.Row.Equals(otherCell.Row) &&
                   this.Col.Equals(otherCell.Col);
        }

        public override int GetHashCode()
        {
            return this.Heigth.GetHashCode() ^
                this.Row.GetHashCode() ^
                this.Col.GetHashCode();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string startPointAsString = Console.ReadLine();
            var papaz = startPointAsString.Split(' ');
            var firstStartLevel = int.Parse(papaz[0]);
            var secondStartRow = int.Parse(papaz[1]);
            var thirdStartCol = int.Parse(papaz[2]);

            string nextLine = Console.ReadLine();
            var papaz2 = nextLine.Split(' ');
            var mateixLevel = int.Parse(papaz2[0]);
            var matrixRows = int.Parse(papaz2[1]);
            var matrixCols = int.Parse(papaz2[2]);

            var used = new HashSet<Cell>();
            char[, ,] labirinth = new char[mateixLevel, matrixRows, matrixCols];

            for (int i = 0; i < mateixLevel; i++)
            {
                for (int j = 0; j < matrixRows; j++)
                {
                    string matrixRow = Console.ReadLine();
                    for (int k = 0; k < matrixCols; k++)
                    {
                        labirinth[i, j, k] = matrixRow[k];
                        if (labirinth[i, j, k] == '#')
                        {
                            used.Add(new Cell(i, j, k, -1));
                        }
                    }
                }
            }

            var startCell = new Cell(firstStartLevel, secondStartRow, thirdStartCol, 0);
            var queque = new Queue<Cell>();

            queque.Enqueue(startCell);
            used.Add(startCell);


            while (queque.Count > 0)
            {
                var cell = queque.Dequeue();

                //left
                if (cell.Col > 0)
                {
                    var newCell = new Cell(cell.Heigth, cell.Row, cell.Col - 1, cell.Queuelevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queque.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //rigth
                if (cell.Col < matrixCols - 1)
                {
                    var newCell = new Cell(cell.Heigth, cell.Row, cell.Col + 1, cell.Queuelevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queque.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //back
                if (cell.Row > 0)
                {
                    var newCell = new Cell(cell.Heigth, cell.Row - 1, cell.Col, cell.Queuelevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queque.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //forward
                if (cell.Row < matrixRows - 1)
                {
                    var newCell = new Cell(cell.Heigth, cell.Row + 1, cell.Col, cell.Queuelevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queque.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //Up
                if (labirinth[cell.Heigth, cell.Row, cell.Col] == 'U')
                {
                    if (cell.Heigth == mateixLevel - 1)
                    {
                        Console.WriteLine(cell.Queuelevel + 1);
                        Environment.Exit(0);
                    }
                    else
                    {
                        var newCell = new Cell(cell.Heigth + 1, cell.Row, cell.Col, cell.Queuelevel + 1);
                        if (!used.Contains(newCell))
                        {
                            queque.Enqueue(newCell);
                            used.Add(newCell);
                        }
                    }
                }

                //down
                if (labirinth[cell.Heigth, cell.Row, cell.Col] == 'D')
                {
                    if (cell.Heigth == 0)
                    {
                        Console.WriteLine(cell.Queuelevel + 1);
                        Environment.Exit(0);
                    }
                    else
                    {
                        var newCell = new Cell(cell.Heigth - 1, cell.Row, cell.Col, cell.Queuelevel + 1);
                        if (!used.Contains(newCell))
                        {
                            queque.Enqueue(newCell);
                            used.Add(newCell);
                        }
                    }
                }
        }
                   
                  //int steps = 0;
                  //OrderedSet<int> solves = new OrderedSet<int>();
                  // Solve(firstStartLevel, secondStartRow, thirdStartCol, labirinth, steps, solves);

                  // Console.WriteLine(solves.First());

            }


        private static void Solve(int heigth, int row, int col, char[, ,] labirinth, int steps, OrderedSet<int> solves)
        {


            //bounderies
            if (row < 0 || row >= labirinth.GetLength(1) || 
                col < 0 || col >= labirinth.GetLength(2))
            {
                return;
            }

            //impossible cubes
            if (labirinth[heigth, row, col] == '#' || labirinth[heigth, row, col] == 'V')
            {
                return;
            }

            //go up
            if (labirinth[heigth, row, col] == 'U')
            {
                if (heigth == labirinth.GetLength(0) - 1)
                {
                    solves.Add(steps+1);
                    //Print(labirinth);
                    return;
                }
                else
                {
                    labirinth[heigth, row, col] = 'V';

                    Solve(heigth + 1, row, col, labirinth, steps + 1, solves);

                    labirinth[heigth, row, col] = 'U';
                }
            }
            //go down
            if (labirinth[heigth, row, col] == 'D')
            {
                if (heigth == 0)
                {
                    solves.Add(steps + 1);
                    return;
                   // Print(labirinth);
                }
                else
                {
                    labirinth[heigth, row, col] = 'V';

                    Solve(heigth - 1, row, col, labirinth, steps + 1, solves);

                    labirinth[heigth, row, col] = 'D';
                }

            }


            labirinth[heigth,row,col] = 'V';
    
            Solve(heigth, row - 1, col, labirinth, steps + 1, solves);
            Solve(heigth, row, col + 1, labirinth, steps + 1, solves);
            Solve(heigth, row + 1, col, labirinth, steps + 1, solves);
            Solve(heigth, row, col - 1, labirinth, steps + 1, solves);
        
            labirinth[heigth, row, col] = '.';
        }

        private static void Print(char[, ,] labirinth)
        {
            for (int i = 0; i < labirinth.GetLength(0); i++)
            {
                for (int j = 0; j < labirinth.GetLength(1); j++)
                {
                    for (int k = 0; k < labirinth.GetLength(2); k++)
                    {

                        if (labirinth[i, j, k] == 'V')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write("{0,5}", labirinth[i,j,k]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
