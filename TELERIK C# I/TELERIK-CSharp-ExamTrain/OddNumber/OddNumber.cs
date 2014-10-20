using System;
using System.Numerics;
class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger result = BigInteger.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            result ^= BigInteger.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}
