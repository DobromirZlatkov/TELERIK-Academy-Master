using System;
using System.Numerics;
class CardWarsBatka
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger firstPlayerResult = 0;
        BigInteger secondPlayerResult = 0;
        BigInteger firstPlayerScore = 0;
        BigInteger secondPlayerScore = 0;


        bool caseXfirst = false;
        bool caseXsecond = false;
        int firstGamesWon = 0;
        int secondGamesWon = 0;

        for (int i = 0; i < n; i++)
        {
            firstPlayerResult = 0;
            secondPlayerResult = 0;
           
            for (int j = 0; j < 3; j++)
            {
                string cardsFirstPlayer = Console.ReadLine();

                switch (cardsFirstPlayer)
                {
                    case "2":
                        firstPlayerResult += 10;
                        break;
                    case "3":
                        firstPlayerResult += 9;
                        break;
                    case "4":
                        firstPlayerResult += 8;
                        break;
                    case "5":
                        firstPlayerResult += 7;
                        break;
                    case "6":
                        firstPlayerResult += 6;
                        break;
                    case "7":
                        firstPlayerResult += 5;
                        break;
                    case "8":
                        firstPlayerResult += 4;
                        break;
                    case "9":
                        firstPlayerResult += 3;
                        break;
                    case "10":
                        firstPlayerResult += 2;
                        break;
                    case "A":
                        firstPlayerResult += 1;
                        break;
                    case "J":
                        firstPlayerResult += 11;
                        break;
                    case "Q":
                        firstPlayerResult += 12;
                        break;
                    case "K":
                        firstPlayerResult += 13;
                        break;
                    case "Z":
                        firstPlayerScore *= 2;
                        break;
                    case "Y":
                        firstPlayerScore -= 200;
                        break;
                    case "X":
                        caseXfirst = true;
                        break;
                }               
            }
            for (int u = 0; u < 3; u++)
            {
                string cardsFirstPlayer = Console.ReadLine();
                switch (cardsFirstPlayer)
                {
                    case "2":
                        secondPlayerResult += 10;
                        break;
                    case "3":
                        secondPlayerResult += 9;
                        break;
                    case "4":
                        secondPlayerResult += 8;
                        break;
                    case "5":
                        secondPlayerResult += 7;
                        break;
                    case "6":
                        secondPlayerResult += 6;
                        break;
                    case "7":
                        secondPlayerResult += 5;
                        break;
                    case "8":
                        secondPlayerResult += 4;
                        break;
                    case "9":
                        secondPlayerResult += 3;
                        break;
                    case "10":
                        secondPlayerResult += 2;
                        break;
                    case "A":
                        secondPlayerResult += 1;
                        break;
                    case "J":
                        secondPlayerResult += 11;
                        break;
                    case "Q":
                        secondPlayerResult += 12;
                        break;
                    case "K":
                        secondPlayerResult += 13;
                        break;
                    case "Z":
                        secondPlayerScore *= 2;
                        break;
                    case "Y":
                        secondPlayerScore -= 200;
                        break;
                    case "X":
                        caseXsecond = true;
                        break;
                }              
            }    

            if (caseXfirst == true && caseXsecond == true)
            {
                firstPlayerScore += 50;
                secondPlayerScore += 50;
                caseXsecond = false;
                caseXfirst = false;
            }

            if (firstPlayerResult > secondPlayerResult)
            {
                firstPlayerScore += firstPlayerResult;
                firstGamesWon++;
            }
            else if (secondPlayerResult > firstPlayerResult)
            {
                secondPlayerScore += secondPlayerResult;
                secondGamesWon++;
            }                       
        }
        // solutions

        if (caseXfirst == true && caseXsecond == false)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
           
        }
        else if (caseXfirst == false && caseXsecond == true)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");           
        }
        else if (firstPlayerScore > secondPlayerScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: " + firstPlayerScore);
            Console.WriteLine("Games won: " + firstGamesWon);
        }
        else if (secondPlayerScore > firstPlayerScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: " + secondPlayerScore);
            Console.WriteLine("Games won: " + secondGamesWon);
        }
        else if (firstPlayerScore == secondPlayerScore)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: " + firstPlayerScore);
        }
    }
}
