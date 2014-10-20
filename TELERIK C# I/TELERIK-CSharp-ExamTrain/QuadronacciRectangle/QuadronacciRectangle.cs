using System;
using System.Numerics;
class QuadronacciRectangle
{
    static void Main()
    {
        BigInteger firstMember = int.Parse(Console.ReadLine());
        BigInteger secondMember = int.Parse(Console.ReadLine());
        BigInteger thirdMember = int.Parse(Console.ReadLine());
        BigInteger fouthMember = int.Parse(Console.ReadLine());

        int R = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int papaz = C;
        Console.Write(firstMember + " ");
        Console.Write(secondMember + " ");
        Console.Write(thirdMember + " ");
        Console.Write(fouthMember + " ");
       
        for (int i = 0; i < R; i++)
        {
            if (i == 0)
            {
                C = C - 4;
            }
            else
            {
                C = papaz;
            }
            for (int j = 0; j < C; j++)
            {              
               
                BigInteger temp = firstMember + secondMember + thirdMember + fouthMember;
                firstMember = secondMember;
                secondMember = thirdMember;
                thirdMember = fouthMember;
                fouthMember = temp;
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
    }
}
