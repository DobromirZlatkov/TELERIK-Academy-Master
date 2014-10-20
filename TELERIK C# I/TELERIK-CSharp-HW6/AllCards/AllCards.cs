using System;
class AllCards
{
    static void Main()
    {
        string type = "spades"; 
        for (int j = 0; j < 4; j++)
        {                  
            for (int i = 1; i <= 13; i++)
            {
                string card = " ";
                
                switch (i)
                {
                    case 1:
                        card = "two";
                        break;
                    case 2:
                        card = "three";
                        break;
                    case 3:
                        card = "four";
                        break;
                    case 4:
                        card = "five";
                        break;
                    case 5:
                        card = "six";
                        break;
                    case 6:
                        card = "seven";
                        break;
                    case 7:
                        card = "eight";
                        break;
                    case 8:
                        card = "nine";
                        break;
                    case 9:
                        card = "ten";
                        break;
                    case 10:
                        card = "Jack";
                        break;
                    case 11:
                        card = "Queen";
                        break;
                    case 12:
                        card = "King";
                        break;
                    case 13:
                        card = "Ace";
                        break;
                }
                Console.WriteLine(card + " " + type);
            }
            if (j == 1)
            {
                type = "hearts";
            }
            else if (j == 2)
            {
                type = "diamonds";
            }
            else
            {
                type = "clubs";
            }
        }
    }
}
