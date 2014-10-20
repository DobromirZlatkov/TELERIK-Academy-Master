using System;
using System.Numerics;
class SubsetSum2
{
    static void Main()
    {
        BigInteger S = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger[] numbers = new BigInteger[n];
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = BigInteger.Parse(Console.ReadLine());
        }
        for (int i = 1; i < Math.Pow(2, n); i++)
        {
            BigInteger sum = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                int mask = (i >> j) & 1;
                Console.Write(mask);
                Console.Write("*" + numbers[j] );
                sum += mask * numbers[j];
                Console.WriteLine("="+sum);
            }
            Console.WriteLine();
            if (sum == S)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
