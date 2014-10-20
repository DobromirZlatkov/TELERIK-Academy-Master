using System;
class BitBall
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        int fieldLennght = 8;
        for (int i = 0; i < fieldLennght; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < fieldLennght; j++)
            {
                int bit = (number >> j) & 1;
                if (bit == 1)
                {
                    matrix[i, j] = 1;
                }               
            }
        }
        for (int i = 0; i < fieldLennght; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < fieldLennght; j++)
            {
                int bit = (number >> j) & 1;
                if (bit == 1)
                {
                    if (matrix[i,j] == 1)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 2;
                    }
                }
               
            }
        }
        int counter1 = 0;
        int counter2 = 0;
        for (int col = 0; col < fieldLennght; col++)
        {
            for (int row = 0; row < fieldLennght; row++)
            {
                if (matrix[row,col] == 1)//smenq mestata na row i col da vurvi otgore nadole hmmm !
                {
                    break;
                }
                else if (matrix[row,col] == 2)
                {
                    counter2++;
                    break;
                }
            }
        }
        for (int col = 0; col < fieldLennght; col++)
        {
            for (int row = fieldLennght - 1; row >= 0; row--)
            {
                if (matrix[row, col] == 1)//smenq mestata na row i col da vurvi otgore nadole hmmm !
                {
                    counter1++;
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    break;
                }
            }
        }
        Console.WriteLine(counter1 + ":" + counter2);
    }
}
