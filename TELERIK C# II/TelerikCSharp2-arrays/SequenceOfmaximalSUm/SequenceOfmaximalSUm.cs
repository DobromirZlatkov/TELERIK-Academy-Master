using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfmaximalSUm
{
    class SequenceOfmaximalSUm
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the sequence of maximal 
             * sum in given array. Example:
	        {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	        Can you do it with only one loop (with single scan 
             * through the elements of the array)?
            */

            // link for Kadane's algorithm
            // http://en.wikipedia.org/wiki/Maximum_subarray_problem

            Console.WriteLine("Enter size of the array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("FIll the array");
            // load the array
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSoFar = numbers[0];
            int maxEndingHere = numbers[0];
            int start = 0;
            int sequenceStart = 0;
            int sequenceEnd = 0;
            // search for sequence with maximal sum
            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxEndingHere < 0)
                {
                    maxEndingHere = numbers[i];
                    sequenceStart = i;
                }
                else
                {
                    maxEndingHere += numbers[i];
                }
                if (maxEndingHere >= maxSoFar)
                {
                    maxSoFar = maxEndingHere;
                    start = sequenceStart;
                    sequenceEnd = i;
                }
            }
            //print result
            Console.WriteLine(new string('-', 50));
            Console.Write("The sequence of maximal sum in given array is :");
            for (int i = start; i <= sequenceEnd; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sequence sum is: {0}", maxSoFar);
            Console.WriteLine(new string('-', 50));
        }
    }
}
