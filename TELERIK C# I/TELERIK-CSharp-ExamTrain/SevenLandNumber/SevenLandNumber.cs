using System;
class SevenLandNumber
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        if (k % 10 == 6 && (k / 10) % 10 != 6)
        {
            k += 3;
        }
        else if (k % 10 == 6 && (k / 10) % 10 == 6)
        {
            if (k >= 66 && k < 666)
            {
               k += 33; 
            }            
        }
        if (k == 666)
        {
            k += 333;
        }
        Console.WriteLine(k + 1);
    }
}
