using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDynamicOptimization
{
    class FibonacciDynamicOptimization
    {
        public static 
        static void Main(string[] args)
        {


            for (int i = 0; i < 10; i++)
            {
                int[] numbers = { 4, 2, 15, 56, 123, 543323, 12, 634 };

                int[] sums = CalculateSums(numbers);

                foreach (var sum in sums)
                {
                    Console.WriteLine(sum);
                }
            }

          
        }

        private static int[] CalculateSums(int[] numbers)
        {
           
        }
    }
}
