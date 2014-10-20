using System;
using System.Numerics;
class CalculatesNK
{
    static void Main()
    {
        Console.WriteLine("(1<N<K).");
        Console.WriteLine("Enter N");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorielK = 1;
        BigInteger factorielN = 1;
        BigInteger factorielKN = 1;
        BigInteger KminusN = k - n;
        if (n > 1 && k > n)
        {
            do
            {
                factorielN *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("n! =" + factorielN);
            do
            {
                factorielK *= k;
                k--;
            } while (k > 0);
            Console.WriteLine("k! =" + factorielK);
            do
            {
                factorielKN *= KminusN;
                KminusN--;
            } while (KminusN > 0);
            Console.WriteLine("kn! = " + factorielKN);
            BigInteger result = (factorielN * factorielK) / factorielKN;
            Console.WriteLine("N!*K!/(K-N)! = {0}", result);
        }
    }
}
