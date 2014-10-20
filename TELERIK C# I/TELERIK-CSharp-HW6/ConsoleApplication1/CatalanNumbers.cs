using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        BigInteger Cn = 1;
        BigInteger factorial2N = 1;
        BigInteger factorialN1 = 1;
        BigInteger factorialN = 1;

        if (n >= 1)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial2N *= i;
            }
            for (int i = 1; i <= n+1; i++)
            {
                factorialN1 *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            Cn = factorial2N / (factorialN1 * factorialN);
            Console.WriteLine("Catalan number = {0}",Cn);
        }
        else if (n == 0)
        {
            Console.WriteLine("Catalan number = {0}", Cn);
        }
    }
}
