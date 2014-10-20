using System;
class SpiralOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int power = 1;
        int zeroes = 0;
        while (Math.Pow(5, power) <= n)
        {
            zeroes += n / (int)Math.Pow(5, power);
            power++;
        }
        Console.WriteLine(zeroes);
    }
}
