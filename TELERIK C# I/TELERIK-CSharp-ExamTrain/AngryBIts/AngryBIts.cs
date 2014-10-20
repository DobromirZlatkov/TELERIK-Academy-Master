using System;
class AngryBIts
{
    static void Main()
    {
        int[,] matrix = new int[8, 16];
        

        for (int i = 0; i < 8; i++)
        {
            ushort numbers = ushort.Parse(Console.ReadLine());
            for (int j= 0; j < 16; j++)
            {
                matrix[i, j] = (numbers >> j) & 1;
            }
        }
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 16; j++)
        //    {
        //        Console.Write(matrix[i,j]);
        //    }
        //    Console.WriteLine();
        //}
        
        string direction = "up";
        
        int pigsDestroyetCounter = 0;
        int pathCOunt = 0;
        int result = 0;
        int row = 0;
        int col = 0;
        bool isPigHit = true;
        bool imaLiPatica = false;

        for (int p = 1; p < 1000;p++)
        {
            int end = 0;
            int breaker = 0;
            
            if (isPigHit)
            {
                direction = "up";
                for (int i = 8; i < 16; i++)// // tursim patica za izstrelvane
                {
                    if (breaker == 10)
                    {
                        break;
                    }
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrix[j, i] == 1)
                        {
                            imaLiPatica = true;
                            matrix[j, i] = 0;
                            row = j;
                            col = i;
                            breaker = 10;
                            break;
                        }
                        else
                        {
                            imaLiPatica = false;
                        }

                    }
                }
            }
            isPigHit = false;


            // smqna na posokite
            if (row + 1 > 7 && direction == "down" && col > 0)
            {
                isPigHit = true;
                pathCOunt = 0;
                continue;
            }
            else if (row - 1 < 0 && direction == "up" && col > 0)
            {
                direction = "down";
            }
            else if (col - 1 < 0 )
            {
                isPigHit = true;
                pathCOunt = 0;
                continue;
            }


            // izpulnenie na usloviqta
            if (direction == "up")
            {
                row--;
                col--;
                pathCOunt++;
            }
            if (direction == "down")
            {
                row++;
                col--;
                pathCOunt++;
            }
          
            //proverka dali e oceleno prase
            if (matrix[row, col] == 1 && col < 8 && imaLiPatica)
            {
                isPigHit = true;
                //for (int y = row-1; y < row + 2; y++)
                //    for (int x = col-1; x < col + 2; x++)
                //    {
                //        if (x < 0 || x > 7 || y < 0 || y > 7) continue;
                //        if (matrix[y, x] > 0)
                //        {
                //            matrix[y, x] = 0;
                //            pigsDestroyetCounter++;
                //        }
                //    }
                //end = pathCOunt * pigsDestroyetCounter;               
                //result += end;              
                //pathCOunt = 0;
                //pigsDestroyetCounter = 0;

                if (isPigHit)
                {
                    bool papaz = true;
                    for (int i = 0; i < 8; i++)//proverka dali ima ostanali praseta za da ne pra6tam i drugite ptici v ataka
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (matrix[i, j] == 1)
                            {
                                i = 7;
                                papaz = false;
                                break;
                            }
                        }
                    }
                    if (papaz)
                    {
                        p = 999;
                    }

                }


                if (col > 0 && row > 0 && row < 7)// proverka dali ne e dolepeno do stenata
                {
                    matrix[row, col] = 0;
                    pigsDestroyetCounter++;
                    if (matrix[row + 1, col] == 1)//otdolu
                    {
                        matrix[row + 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row - 1, col] == 1)//otgore
                    {
                        matrix[row - 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col + 1] == 1)// ot lqvo
                    {
                        matrix[row, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col - 1] == 1)//ot dqsno
                    {
                        matrix[row, col - 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col + 1] == 1) // diagonal lqvo dolu
                    {
                        matrix[row + 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col - 1] == 1) // diagonal dqsno dolu
                    {
                        matrix[row + 1, col - 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row - 1, col + 1] == 1)// diagonal gore lqvo ot zada4ata diagramata
                    {
                        matrix[row - 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row - 1, col - 1] == 1)// diagonal gore dqsno
                    {
                        matrix[row - 1, col - 1] = 0;
                        pigsDestroyetCounter++;
                    }
                }
                // dali praseto e dolepeno do gornata strana na matricata
                if (col > 0 && row == 0)
                {
                    matrix[row, col] = 0;
                    pigsDestroyetCounter++;
                    if (matrix[row + 1, col] == 1)//otdolu
                    {
                        matrix[row + 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col + 1] == 1)// ot lqvo
                    {
                        matrix[row, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col - 1] == 1)//ot dqsno
                    {
                        matrix[row, col - 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col + 1] == 1) // diagonal lqvo dolu
                    {
                        matrix[row + 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col - 1] == 1) // diagonal dqsno dolu
                    {
                        matrix[row + 1, col - 1] = 0;
                        pigsDestroyetCounter++;
                    }
                }
                // proverka gore v ygyla
                if (col == 0 && row == 0)
                {
                    matrix[row, col] = 0;
                    pigsDestroyetCounter++;
                    if (matrix[row, col + 1] == 1)// ot lqvo
                    {
                        matrix[row, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col] == 1)//otdolu
                    {
                        matrix[row + 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col + 1] == 1) // diagonal lqvo dolu
                    {
                        matrix[row + 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                }
                //proverka dolu v ugula
                if (col == 0 && row == 7)
                {
                    matrix[row, col] = 0;
                    pigsDestroyetCounter++;
                    if (matrix[row - 1, col] == 1)//otgore
                    {
                        matrix[row - 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col + 1] == 1)// ot lqvo
                    {
                        matrix[row, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row - 1, col + 1] == 1)// diagonal gore lqvo ot zada4ata diagramata
                    {
                        matrix[row - 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                }
                // stenata dolu proverka
                if (col > 0 && row == 7)
                {
                    matrix[row, col] = 0;
                    pigsDestroyetCounter++;
                    if (matrix[row - 1, col] == 1)//otgore
                    {
                        matrix[row - 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col + 1] == 1)// ot lqvo
                    {
                        matrix[row, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row - 1, col + 1] == 1)// diagonal gore lqvo ot zada4ata diagramata
                    {
                        matrix[row - 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row - 1, col - 1] == 1)// diagonal gore dqsno
                    {
                        matrix[row - 1, col - 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col - 1] == 1)//ot dqsno
                    {
                        matrix[row, col - 1] = 0;
                        pigsDestroyetCounter++;
                    }
                }
                // dalepeno do stenata ot dqsno
                if (col == 0 && row < 7 && row > 0)
                {
                    matrix[row, col] = 0;
                    pigsDestroyetCounter++;
                    if (matrix[row - 1, col] == 1)//otgore
                    {
                        matrix[row - 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row, col + 1] == 1)// ot lqvo
                    {
                        matrix[row, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col] == 1)//otdolu
                    {
                        matrix[row + 1, col] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row - 1, col + 1] == 1)// diagonal gore lqvo ot zada4ata diagramata
                    {
                        matrix[row - 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                    if (matrix[row + 1, col + 1] == 1) // diagonal lqvo dolu
                    {
                        matrix[row + 1, col + 1] = 0;
                        pigsDestroyetCounter++;
                    }
                }
                end = pathCOunt * pigsDestroyetCounter;
                result += end;
                pathCOunt = 0;
                pigsDestroyetCounter = 0;
               
            }           
        }
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 16; j++)
        //    {
        //        Console.Write(matrix[i, j]);
        //    }
        //    Console.WriteLine();
        //}
        bool winOr = true;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i,j] == 1)
                {
                    Console.WriteLine(result + " No");
                    winOr = false;
                    i = 7;
                    break;
                }
            }
        }
        if (winOr)
        {
            Console.WriteLine(result + " Yes"); 
        }
        
    }
}


