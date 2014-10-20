using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfStrings
{
    class MatrixOfStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N and M");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];

            Console.WriteLine("Fill them matrix");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine(new string('-',40));
            Console.WriteLine("This is how you matrix look like");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5}",matrix[i,j]);
                }
                Console.WriteLine();
            }

            int oldRow = 0;
            int oldCol = 0;
            int counter = 1;
            int result = int.MinValue;
            string currentString = "";
            // diagonal right check
            for (int row = 0; row < n - 1; row++)
            {
                
                for (int col = 0; col < m - 1; col++)
                {
                    oldRow = row;
                    oldCol = col;
                    counter = 1;
                    while (matrix[oldRow, oldCol] == matrix[oldRow + 1, oldCol + 1])
                    {
                        counter++;
                        oldCol++;
                        oldRow++;
                        if (oldCol >= m - 1 || oldRow >= n - 1)
                        {
                            break;
                        }
                    }
                    
                    if (result < counter)
                    {
                        result = counter;
                        currentString = matrix[row, col];
                    }
                }
            }
           
                //check diagonal left

            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 1; col < m; col++)
                {
                    oldRow = row;
                    oldCol = col;
                    counter = 1;
                    while (matrix[oldRow, oldCol] == matrix[oldRow + 1, oldCol - 1])
                    {
                        counter++;
                        oldCol--;
                        oldRow++;
                        if (oldCol <= 0 || oldRow >= n - 1)
                        {
                            break;
                        }
                    }

                    if (result < counter)
                    {
                        result = counter;
                        currentString = matrix[row, col];
                    }
                }
            }

            // check rows 
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < m; col++)
                {

                    oldRow = row;
                    oldCol = col;
                    counter = 1;
                    while (matrix[oldRow, oldCol] == matrix[oldRow + 1, oldCol])
                    {
                        counter++;                       
                        oldRow++;
                        if (oldRow >= n - 1)
                        {
                            break;
                        }
                    }

                    if (result < counter)
                    {
                        result = counter;
                        currentString = matrix[row, col];
                    }
                }
            }
            // check cols
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m-1; col++)
                {

                    oldRow = row;
                    oldCol = col;
                    counter = 1;
                    while (matrix[oldRow, oldCol] == matrix[oldRow, oldCol + 1])
                    {
                        counter++;
                        oldCol++;
                        if (oldCol >= m - 1)
                        {
                            break;
                        }
                    }

                    if (result < counter)
                    {
                        result = counter;
                        currentString = matrix[row, col];
                    }
                }
            }
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Longest sequence = {0}", result);
            Console.WriteLine("String from the sequence: {0}", currentString);
            Console.WriteLine(new string('-', 40));
                                    
        }
    }
}
