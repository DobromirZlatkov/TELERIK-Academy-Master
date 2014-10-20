using System;
class Poker
{
    static void Main()
    {
        int[] cards = new int[5];
        for (int i = 0; i < 5; i++)
        {
            string card = Console.ReadLine();
            switch (card)
            {
                case "J":
                    card = "11";
                    break;
                case "Q":
                    card = "12";
                    break;
                case "K":
                    card = "13";
                    break;
                case "A":
                    card = "1";
                    break;

            }
            int numberCards = int.Parse(card);
            cards[i] = numberCards;
        }
        Array.Sort(cards);       
        int straightCOunt = 1;
        int aceStraightCOunter = 2;
        int equalCounter = 0;
        for (int i = 1; i < 5; i++)
        {
            if ((cards[0] == cards[i] - i )) // vski4ki slu4ai bez 10 J Q K A
            {
                straightCOunt++;
            }      
        }
        //proverka za  A K Q J 10 streight
        for (int i = 2; i < 5; i++)
        {
            if (cards[1] - 1 == (cards[i] - i ) && (cards[0] == 1))
            {               
                aceStraightCOunter++;
            }
        }

        int q1 = cards[0];
        int q2 = cards[1];
        int q3 = cards[2];
        int q4 = cards[3];
        int q5 = cards[4];

        //impossible
        if (q1 == q2 && q2 == q3 && q3 == q4 && q4 == q5)
        {
            Console.WriteLine("Impossible");
            return;
        }
        //four of a kind
        if ((q1 == q2 && q2 == q3 && q3 == q4) || (q2 == q3 && q3 == q4 && q4 == q5))
        {
            Console.WriteLine("Four of a Kind");
            return;
        }
        // full house check
        if ((q1 == q2 && q2 == q3) && (q4 == q5) || (q1 == q2) && (q3 == q4 && q4 == q5))
        {
            Console.WriteLine("Full House");
            return;
        }
        //three of a kind
        if (q1 == q2 && q2==q3 || q2 == q3 && q3 == q4 || q3 == q4 && q4 == q5)
        {
            Console.WriteLine("Three of a Kind");
            return;
        }
        // two pair
        if (q1 == q2 && q3 == q4 
            || q1 == q2 && q4 == q5 
            || q2 == q3 && q4 == q5)
        {
            Console.WriteLine("Two Pairs");
            return;
        }

        // one pair check
        if (q1 == q2 || q2 == q3 || q3 == q4 || q4 == q5)
        {
            Console.WriteLine("One Pair");
            return;
        }
        // print streight
        if (straightCOunt == 5 || aceStraightCOunter == 5)
        {
            Console.WriteLine("Straight");
        }
        else
        {
            Console.WriteLine("Nothing");
        }
    }
}
