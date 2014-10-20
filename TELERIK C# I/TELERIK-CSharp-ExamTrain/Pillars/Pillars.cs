using System;
class Pillars
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
      
        int firsthalfBitCounter = 0;
        int secondHalfBitCounter = 0;       
        int col = 7;
        bool noPillars = false;

        while (col >= 0)
        {
            secondHalfBitCounter = 0;
            firsthalfBitCounter = 0;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[j,i] == 1)
                    {
                        firsthalfBitCounter++;
                    }
                }
            }
            for (int i = col + 1; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[j, i] == 1)
                    {
                        secondHalfBitCounter++;
                    }
                }
            }
            if (firsthalfBitCounter == secondHalfBitCounter)
            {
                noPillars = true;
                break;             
            }
            else
            {
                col--;
            }                                
        }
        if (noPillars)
        {
            Console.WriteLine(col);
            Console.WriteLine(secondHalfBitCounter); 
        }
        else
        {
            Console.WriteLine("No");            
        }
      
    }
}

