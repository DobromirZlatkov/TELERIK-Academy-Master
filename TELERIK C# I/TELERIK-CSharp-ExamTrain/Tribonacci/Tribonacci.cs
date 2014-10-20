using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger firstMemner = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumner = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger next = 0;
        if (n == 1)
        {
            Console.WriteLine(firstMemner);
        }
        else if (n == 2)
        {

            Console.WriteLine(secondNumner);
        }
        else if (n == 3)
        {
            Console.WriteLine(thirdMember);
        }
        else
        {
            for (int i = 0; i < n - 3; i++)
            {
                next = firstMemner + secondNumner + thirdMember;
                firstMemner = secondNumner;
                secondNumner = thirdMember;
                thirdMember = next;

            }
            Console.WriteLine(next);
        }
        
    }
}
