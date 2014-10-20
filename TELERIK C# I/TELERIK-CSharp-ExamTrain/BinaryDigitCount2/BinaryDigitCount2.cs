using System;
using System.Numerics;
class BinaryDigitCount2
{
    static void Main()
    {
        int B = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            int oneDigitCount = 0;
            int zeroDigitCount = 0;

            string numberAsString = Convert.ToString(number, 2);

            for (int j = 0; j < numberAsString.Length; j++)
            {
                if (numberAsString[j] == '1')
                {
                    oneDigitCount++;
                }
                else
                {
                    zeroDigitCount++;
                }
            }
            if (B == 1)
            {
                Console.WriteLine(oneDigitCount);
            }
            else
            {
                Console.WriteLine(zeroDigitCount);
            }
        }
    }
}
