using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a = 11m / 10m;
            Console.WriteLine(a);
        }
    }
}
using System;
class PeaceOFCake
{
    static void Main()
    {
        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());
        decimal D = decimal.Parse(Console.ReadLine());
 
        decimal firstFraction = A / B;
        decimal secondFraction = C / D;
 
        decimal result = firstFraction + secondFraction;
 
              
        decimal denominator = B * D;
         
        decimal nominator = result * denominator;
 
        if (nominator < 1)
        {
            while (nominator < 1)
            {
                nominator *= 3;
                denominator *= 3;
            }           
        }
 
        if (result >= 1 && nominator >= 1)
        {
            Console.WriteLine((long)result);
            Console.WriteLine((long)nominator + "/" + denominator);           
        }
        else if (result < 1 && nominator >= 1)
        {          
            Console.WriteLine("{0:f22}", result);
            Console.WriteLine((long)nominator + "/" + denominator);
        }
        else if (result < 1 && nominator < 1)
        {
            Console.WriteLine("{0:f22}", result);
            Console.WriteLine(1 + "/" + denominator);
        }
        else if (result >= 1 && nominator < 1)
        {
            Console.WriteLine((long)result);
            Console.WriteLine(1 + "/" + denominator);
        }
    }
}