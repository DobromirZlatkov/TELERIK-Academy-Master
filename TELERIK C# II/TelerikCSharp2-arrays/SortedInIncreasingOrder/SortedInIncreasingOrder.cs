using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedInIncreasingOrder
{
    class SortedInIncreasingOrder
    {
        static bool AreSorted(List<long> array)
        {

            /** Write a program that reads an array of integers 
             * and removes from it a minimal number of elements
             * in such way that the remaining array is sorted in
             * increasing order. Print the remaining sorted array.
             * Example:
	    {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
            */

            bool isSorted = true;
            for (int i = 0; i < array.Count - 1; i++)
            {
                if (!(array[i] <= array[i + 1]))
                {
                    isSorted = false;
                }
            }
            return isSorted;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of the array:");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter numbers to fill the array");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int lenght = 0;
            int biggestLenght = 0;

            List<long> bestResult = new List<long>();

            int maxSubsets = (int)Math.Pow(2, numbers.Count);
            for (int i = 1; i < maxSubsets; i++)
            {
                List<long> result = new List<long>();

                for (int j = 0; j <= numbers.Count; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        result.Add(numbers[j]);
                        lenght++;
                    }
                }
                if (AreSorted(result))
                {
                    if (lenght > biggestLenght)
                    {
                        biggestLenght = lenght;
                        bestResult = result;
                    }
                }
                lenght = 0;
               
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Sorted array");
            foreach (var item in bestResult)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }
    }
}
