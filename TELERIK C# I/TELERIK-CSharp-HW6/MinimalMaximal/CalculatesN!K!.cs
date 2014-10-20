using System;
using System.Numerics;
class CalculatesN
{
    static void Main()
    {
        Console.WriteLine("(1<K<N).");
        Console.WriteLine("Enter N");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K");
        int k = int.Parse(Console.ReadLine());
        BigInteger facturielK = 1;
        BigInteger facturielN = 1;
        if (k > 1 && n > k)
        {
            do
            {
                facturielN *= n;
                n--;
            } while (n > 0);
            do
            {
                facturielK *= k;
            } while (k > 0);
            BigInteger result = facturielN / facturielK;
            Console.WriteLine("N!/K! = {0}", result);
        }
        else
        {
            Console.WriteLine("Uslovie za izpulnenie na zada4ata :(1<K<N).");
        }
    }
}
