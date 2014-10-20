using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int col = 0;
        int row = 0;
        string direction = "right";
        for (int i = 1; i <= n * n; i++)
        {

            if (direction == "right" && (row > n - 1 || matrix[row,col] !=0))
            {
                direction = "down";
                col++;
                row--;
            }
            if (direction == "down" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                col--;
                row--;
            }
            if (direction == "left" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col--;
                row++;
            }
            if (direction == "up" && (col < 0|| matrix[row,col] !=0))
            {
                direction = "right";
                col++;
                row++;
            }
            matrix[row, col] = i;
            if (direction == "right")
            {
                row++;
            }
            if (direction == "down")
            {
                col++;
            }
            if (direction == "left")
            {
                row--;
            }
            if (direction == "up")
            {
                col--;
            }
            
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 3}", matrix[j,i]);
            }
            Console.WriteLine();
        }
    }
}