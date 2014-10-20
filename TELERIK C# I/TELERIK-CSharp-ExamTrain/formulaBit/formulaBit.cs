using System;
class formulaBit
{
    static void Main()
    {
        int[,] track = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j <8; j++)
            {
                track[i, j] = ((n >> j) & 1);
            }
        }
        //for (int i = 0; i < 8; i++)
        //{           
        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.Write(track[i, j]); 
        //    }
        //    Console.WriteLine();
        //}
        int row = 0;
        int col = 0;
        string direction = "down";
        string lastDirection = "down";
        int trackCOunter = 0;
        bool exitFOund = false;
        int directionChange = 0;
        while (true)
        {
            if (track[row,col] == 1)
            {
                break;
            }
            trackCOunter++;
            if (row == 7 && col == 7)
            {
                exitFOund = true;
                break;
            }
            
            if (direction == "down" && (row + 1 > 7 || track[row + 1, col] == 1))
            {
                direction = "left";
                lastDirection = "down";
                directionChange++;
                if (col + 1 > 7 || track[row, col + 1] == 1)
                {
                    break;
                }
            }
            else if (direction == "left" && lastDirection == "down" && (col + 1 > 7 || track[row,col + 1] == 1))
            {
                direction = "up";
                
                directionChange++;
                if (row - 1 < 0 || track[row - 1, col] == 1)
                {
                    break;
                }
            }
            else if (direction == "left" && lastDirection == "up" && (col + 1 > 7 || track[row, col + 1] == 1))
            {
                direction = "down";
                
                directionChange++;
                if (row + 1 > 7 || track[row + 1, col] == 1)
                {
                    break;
                }
            }
            else if (direction == "up" && (row - 1 < 0 || track[row - 1, col] == 1))
            {
                direction = "left";
                lastDirection = "up";
                directionChange++;
                if (col + 1 > 7 || track[row, col + 1] == 1)
                {
                    break;
                }
            }


            if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col++;
            }
            else if (direction == "up")
            {
                row--;
            }
        }
        if (exitFOund)
        {
            Console.WriteLine(trackCOunter + " " + directionChange);
        }
        else
        {
            Console.WriteLine("No "+ trackCOunter);
        }
        
    }
}
