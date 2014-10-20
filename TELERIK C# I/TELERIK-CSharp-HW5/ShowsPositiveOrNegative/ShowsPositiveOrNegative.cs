using System;

class ShowsPositiveOrNegative
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers to see their product + or -:");
        int negativeCount = 0;
        int zeroCount = 0;
        for (int i = 0; i < 3; i++)
        {
            int n = int.Parse(Console.ReadLine());
            
            if (n < 0)
            {
                negativeCount++; 
            }
            else if(n == 0)
            {
                zeroCount++;
            }
            

        }
        if (zeroCount > 0)
        {
            Console.WriteLine(0);
        }
        else if (negativeCount == 1 || negativeCount == 3)
        {
            Console.WriteLine("-");
        }        
        else
        {
            Console.WriteLine("+");
        }     
    }
}
