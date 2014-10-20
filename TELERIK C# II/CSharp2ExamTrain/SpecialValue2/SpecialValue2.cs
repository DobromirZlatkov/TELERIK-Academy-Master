using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialValue2
{
    class SpecialValue2
    {
        private static int[][] ReadInput()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] field = new int[n][];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] currentrow = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                field[i] = new int[currentrow.Length];

                for (int j = 0; j < currentrow.Length; j++)
                {
                    field[i][j] = int.Parse(currentrow[j]);
                }
            }
            return field;
        }
        private static bool[][] FullVisited(int[][] field)
        {
            bool[][] visited = new bool[field.Length][];

            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = new bool[field[i].Length];
            }
            return visited;
        }
        private static int FindBEstPath(int[][] field, int column, bool[][] visited)
        {
            int pathCount = 0;
            int currentRow = 0;

            for (int i = 0; i < visited.GetLength(0); i++)
            {
                visited[i] = new bool[field[i].Length];
            }

            while (true)
            {
                pathCount++;
                if (visited[currentRow][column])
                {
                    return -99999;
                }

                if (field[currentRow][column] < 0)
                {
                    return pathCount - field[currentRow][column];
                }

                int nextColumn = field[currentRow][column];
                visited[currentRow][column] = true;
                column = nextColumn;

                currentRow++;

                if (currentRow == field.GetLength(0))
                {
                    currentRow = 0;
                }
            }
        
        }
        
        
        static void Main(string[] args)
        {

            int[][] field = ReadInput();
            bool[][] visited = FullVisited(field);
            int max = int.MinValue;
            for (int column = 0; column < field[0].Length; column++)
            {
                int result = FindBEstPath(field, column, visited);
                if (max < result)
                {
                    max = result;
                }
            }

            Console.WriteLine(max);

        }

        

        
    }
}
