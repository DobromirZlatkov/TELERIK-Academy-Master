using System;
using System.Numerics;

class SequenceOfFibbonacci
{
    static void Main()
    {
        BigInteger firstMember = 0;
        BigInteger secondMember = 1;
        BigInteger member = 0;
        for (int i = 0; i <= 100; i++)
        {
            member = firstMember + secondMember;
            Console.WriteLine(member);
            secondMember = firstMember;
            firstMember = member;
        }
    }
}
