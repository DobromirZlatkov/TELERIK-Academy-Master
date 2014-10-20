using System;
class BonusGame
{
    static void Main()
    {
        Console.WriteLine("Enter number between 1 and 9:");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
            case 2:
            case 3:
                n = n * 10;
                Console.WriteLine("Your score is :{0}", n);
                break;
            case 4:
            case 5:
            case 6:
                n = n * 100;
                Console.WriteLine("Your score is :{0}", n);
                break;
            case 7:
            case 8:
            case 9:
                n = n * 1000;
                Console.WriteLine("Your score is :{0}", n);
                break;
            default:
                Console.WriteLine("Value is not on range of 1...9");
                break;
        }
    }
}

