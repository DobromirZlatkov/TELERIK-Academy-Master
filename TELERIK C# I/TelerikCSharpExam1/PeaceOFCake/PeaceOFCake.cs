using System;
using System.Numerics;


class PeaceOFCake
{
    static void Main()
    {
        BigInteger A = BigInteger.Parse(Console.ReadLine());
        BigInteger B = BigInteger.Parse(Console.ReadLine());
        BigInteger C = BigInteger.Parse(Console.ReadLine());
        BigInteger D = BigInteger.Parse(Console.ReadLine());
        
        decimal firstFraction = (decimal)A / (decimal)B;
        decimal secondFraction = (decimal)C / (decimal)D;

        decimal result = firstFraction + secondFraction;

             
        BigInteger denominator = B * D;
        
        decimal nominator = result * (decimal)denominator;

       

        if (result >= 1)
        {
            Console.WriteLine((BigInteger)result);
            Console.WriteLine((BigInteger)nominator + "/" + denominator);            
        }
        else if (result < 1)
        {           
            Console.WriteLine("{0:f22}", result);
            Console.WriteLine("{0:0}/{1}",nominator , denominator);
        }
        
    }
}
