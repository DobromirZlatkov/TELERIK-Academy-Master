using System;
class Carpets2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int startSlash = n / 2 - 1;
        int endSlash = n / 2 - 1;
        bool isSlash = true;



        for (int row = 0; row < n / 2; row++)
        {
            for (int col = 0; col < n / 2; col++)
            {
                if (startSlash <= col && col <= endSlash)
                {
                    if (isSlash)
                    {
                       matrix[row, col] = 2;
                       matrix[row, n - 1 - col] = 3;
                       matrix[n-1-row, col] = 3;
                       matrix[n-1-row, n - 1 - col] = 2;
                       isSlash = false;
                    }
                    else
                    {
                        matrix[row, col] = 1;
                        matrix[row, n - 1 - col] = 1;
                        matrix[n-1-row, col] = 1;
                        matrix[n-1-row, n - 1 - col] = 1;
                        isSlash = true;
                    }
                }
            }
            isSlash = true;
            startSlash--;
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (matrix[row,col] == 0)
                {
                   Console.Write('.'); 
                }
                else if (matrix[row,col] == 1)
                {
                    Console.Write(' ');
                }
                else if (matrix[row,col] == 2)
                {
                    Console.Write('/');
                }
                else if (matrix[row,col] == 3)
                {
                    Console.Write('\\');
                }
            }

            Console.WriteLine();
        }
    }
}
