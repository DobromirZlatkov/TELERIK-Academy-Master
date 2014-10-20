using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {

        static void Main()
        {
            Console.Write("n = ");
            decimal number = decimal.Parse(Console.ReadLine());

            decimal factorial = Factorial(number);
            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        private static decimal Factorial(decimal number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
       
    }
}
