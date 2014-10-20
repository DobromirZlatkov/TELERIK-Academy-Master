using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursion
{
    class FibonacciRecursion
    {
        static void Main(string[] args)
        {

            long[] papaz = new long[80];
            long result = FibonacciRecursionMethod(79, papaz);
        
            Console.WriteLine(result);

        }

        private static long FibonacciRecursionMethod(long n, long[] papaz)
        {
            if (papaz[n] != 0)
            {
                return papaz[n];
            }

            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            papaz[n] = FibonacciRecursionMethod(n - 1, papaz) + FibonacciRecursionMethod(n - 2, papaz);
    
            return papaz[n];
           
        }

    }
}
