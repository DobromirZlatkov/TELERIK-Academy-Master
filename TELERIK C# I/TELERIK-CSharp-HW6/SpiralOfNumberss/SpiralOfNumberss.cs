using System;
class SpiralOfNumberss
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        string direction = "right";
        int row = 0;
        int col = 0;
        int[,] matrix = new int[n ,n];
        for (int i = 1; i <= n * n; i++)
        {


            if (direction == "right" && (col > n - 1 || matrix[row,col] != 0))
            {
                direction = "down";
                row++;
                col--;
            }
            if (direction == "down" && (row > n - 1 || matrix[row,col] != 0))
            {
                direction = "left";
                col--;
                row--;
            }
            if (direction == "left" && (col < 0 || matrix[row,col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                col++;
                row++;
            }

            matrix[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
            
        }
        for (int k = 0; k < n; k++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 4}", matrix[k, j]);
            }
            Console.WriteLine();
        }
    }
}
