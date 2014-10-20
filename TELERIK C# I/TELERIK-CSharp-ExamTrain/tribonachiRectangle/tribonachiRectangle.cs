using System;
using System.Numerics;
class tribonachiRectangle
{
    static void Main()
    {
        BigInteger firstMember = BigInteger.Parse(Console.ReadLine());
        BigInteger secondMember = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());

        int L = int.Parse(Console.ReadLine());
        if (L == 1)
        {
            Console.WriteLine(firstMember);
        }
        else if (L == 2)
        {
            Console.WriteLine(firstMember);
            Console.WriteLine(secondMember + " " + thirdMember);
        }
        else
        {
            Console.WriteLine(firstMember);
            Console.WriteLine(secondMember + " " + thirdMember);            
            for (int i = 2; i < L; i++)
            {
                int asd = i;
                while (asd >= 0)
                {
                    BigInteger next = firstMember + secondMember + thirdMember;
                    firstMember = secondMember;
                    secondMember = thirdMember;
                    thirdMember = next;
                    if (asd > 0)
                    {
                        Console.Write(next + " ");
                    }                                                         
                    if (asd == 0)
                    {
                        Console.Write(next);
                    }
                    asd--;
                }
                Console.WriteLine();                
            }
        }
    }
}
