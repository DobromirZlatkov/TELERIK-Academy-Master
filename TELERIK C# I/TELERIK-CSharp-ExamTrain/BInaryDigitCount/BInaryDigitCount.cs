using System;
using System.Numerics;



class BInaryDigitCount
{
    static void Main()
    {
        int B = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int zeroCount = 0;
        int oneCount = 0;
        for (int i = 0; i < N; i++)
        {
            long number = long.Parse(Console.ReadLine());
            string papaz = Convert.ToString(number, 2);
            zeroCount = 0;
            oneCount = 0;
            for (int j = 0; j < papaz.Length; j++)
            {
                long bit = ((number >> j) & 1);
                if (bit == 1)
                {
                    oneCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            if (B == 1)
            {
                Console.WriteLine(oneCount);
            }
            else
            {
                Console.WriteLine(zeroCount);
            }
        }        
    }
}
