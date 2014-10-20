using System;
using System.Numerics;

class ZerosBehindN
{
    static void Main()
    {
        Console.Write("Enter Number:");
        int n = int.Parse(Console.ReadLine());
        BigInteger facturielN = 1;
        int ZeroCount = 0;

        for (int i = 1; i <= n; i++)
        {
            facturielN *= i;

        }
        while (facturielN % 10 == 0)
        {

            ZeroCount++;
            facturielN = facturielN / 10;
        }

        Console.WriteLine("Zeros behind N! are :{0}", ZeroCount);
    }
}