using System;
class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());

        int remainder = 1;
        while (remainder > 0)
        {
             remainder = a % b;
             a = b;
             b = remainder;
        }
        Console.WriteLine("Greatest Common Divider = {0}", a);
    }
}
