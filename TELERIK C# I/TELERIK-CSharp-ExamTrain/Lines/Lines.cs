using System;
class Lines
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = (n >> j) & 1;
            }
        }
        int lineCouter = 0;
        int largestLineCOunter = 0;
        int tempLines = 0;
        for (int row = 0; row < 8; row++)// col check lines
        {
            for (int col = 0; col < 8; col++)
            {
                while (matrix[row, col] == 1)
                {
                    lineCouter++;
                    if (col < 7)
                    {
                        col++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (lineCouter > tempLines)
                {
                    tempLines = lineCouter;
                }                
                lineCouter = 0;
            }
        }
        int rowLargestLine = tempLines;

        for (int col = 0; col < 8; col++)// row check lines
        {
            for (int row = 0; row < 8; row++)
            {
                while (matrix[row, col] == 1)
                {
                    lineCouter++;
                    if (row < 7)
                    {
                        row++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (lineCouter > tempLines)
                {
                    tempLines = lineCouter;
                }               
                lineCouter = 0;
            }
        }
        int colLargestLine = tempLines;

        for (int row = 0; row < 8; row++)// col check lines
        {
            for (int col = 0; col < 8; col++)
            {
                while (matrix[row, col] == 1)
                {
                    lineCouter++;
                    if (col < 7)
                    {
                        col++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (lineCouter > tempLines)
                {
                    tempLines = lineCouter;
                }
                if (tempLines == lineCouter)
                {
                    largestLineCOunter++;
                }
                lineCouter = 0;
            }
        }

        for (int col = 0; col < 8; col++)// row check lines
        {
            for (int row = 0; row < 8; row++)
            {
                while (matrix[row, col] == 1)
                {
                    lineCouter++;
                    if (row < 7)
                    {
                        row++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (lineCouter > tempLines)
                {
                    tempLines = lineCouter;
                }
                if (colLargestLine == lineCouter)
                {
                    largestLineCOunter++;
                }
                lineCouter = 0;
            }
        }
        if (tempLines == 1)
        {
            largestLineCOunter /= 2;
        }
        Console.WriteLine(tempLines);
        Console.WriteLine(largestLineCOunter);
    }
}
