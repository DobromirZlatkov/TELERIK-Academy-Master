using System;
using System.Numerics;
class SubsetSum
{
    static void Main()
    {
        BigInteger S = BigInteger.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());
        BigInteger[] numbers = new BigInteger[N];
        int counter = 0;
        for (int i = 0; i < N; i++)
        {
            numbers[i] = BigInteger.Parse(Console.ReadLine());
        }
        for (int i = 1; i < Math.Pow(2, N) ; i++)
        {
            BigInteger sum = 0;
           
            for (int j = 0; j < N; j++)
            {
                sum += ((i >> j) & 1) * numbers[j];
            }
            if (sum == S)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
