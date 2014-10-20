using System;
class BoolsAndCows
{
    static void Main()
    {
        int guessNumber = int.Parse(Console.ReadLine());
        int bullsGuess  = int.Parse(Console.ReadLine());
        int CowsGuess = int.Parse(Console.ReadLine());
        bool solutionFound = false;

        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        int firstDigit = (guessNumber / 1000) % 10;
                        int secondDigit = (guessNumber / 100) % 10;
                        int thirdDigit = (guessNumber / 10) % 10;
                        int forthDigit = (guessNumber / 1) % 10;

                        int oldD1 = d1;
                        int oldD2 = d2;
                        int oldD3 = d3;
                        int oldD4 = d4;

                        int bulls = 0;
                        int cows = 0;

                        // count bulls
                        if (firstDigit == d1)
                        {
                            bulls++;
                            firstDigit = -1; // eliminira tiq 4isla ako sa bikove
                            d1 = -2;
                        }
                        if (secondDigit == d2)
                        {
                            bulls++;
                            secondDigit = -1; // eliminira tiq 4isla ako sa bikove
                            d2 = -2;
                        }
                        if (thirdDigit == d3)
                        {
                            bulls++;
                            thirdDigit = -1; // eliminira tiq 4isla ako sa bikove
                            d3 = -2;
                        }
                        if (forthDigit == d4)
                        {
                            bulls++;
                            forthDigit = -1; // eliminira tiq 4isla ako sa bikove
                            d4 = -2;
                        }
                        //cows
                        if (d1 == secondDigit)
                        {
                            cows++;
                            secondDigit = -1;
                        }
                        else if (d1 == thirdDigit)
                        {
                            cows++;
                            thirdDigit = -1;
                        }
                        else if (d1 == forthDigit)
                        {
                            cows++;
                            forthDigit = -1;
                        }
                        if (d2 == firstDigit)
                        {
                            cows++;
                            firstDigit = -1;
                        }
                        else if (d2 == thirdDigit)
                        {
                            cows++;
                            thirdDigit = -1;
                        }
                        else if (d2 == forthDigit)
                        {
                            cows++;
                            forthDigit = -1;
                        }
                        if (d3 == firstDigit)
                        {
                            cows++;
                            firstDigit = -1;
                        }
                        else if (d3 == secondDigit)
                        {
                            cows++;
                            secondDigit = -1;
                        }
                        else if (d3 == forthDigit)
                        {
                            cows++;
                            forthDigit = -1;
                        }
                        if (d4 == firstDigit)
                        {
                            cows++;
                            firstDigit = -1;
                        }
                        else if (d4 == thirdDigit)
                        {
                            cows++;
                            thirdDigit = -1;
                        }
                        else if (d4 == secondDigit)
                        {
                            cows++;
                            secondDigit = -1;
                        }

                        d1 = oldD1;
                        d2 = oldD2;
                        d3 = oldD3;
                        d4 = oldD4;

                        if (bulls == bullsGuess && cows == CowsGuess)
                        {
                            if (solutionFound)
                            {
                                Console.Write("");
                            }
                            Console.Write(" " + d1 + d2 + d3 + d4);
                            solutionFound = true;
                        }
                    }
                }
            }
        }
        if (!solutionFound)
        {
            Console.WriteLine("No");
        }
    }
}
