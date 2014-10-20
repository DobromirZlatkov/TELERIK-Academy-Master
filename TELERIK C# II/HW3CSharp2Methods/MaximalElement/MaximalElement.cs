using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalElement
{
    class MaximalElement
    {
        static void Main(string[] args)
        {
            /*Write a method that return the maximal element in a portion 
             * of array of integers starting at given index. Using it write
             * another method that sorts an array in ascending / descending
             * order.
            */

            Console.WriteLine("Enter array length");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("FIll the array");
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter start to find maximal element");
            int startSearch = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Maximal number after index {1} = {0}", numbers[FindMaximal(numbers, startSearch)], startSearch); 
            Console.WriteLine(new string('-', 70));

            SortInDescendingOrder(numbers);

            PrintArray(numbers);

            SortInIncreasingOrder(numbers);

            PrintArray(numbers);
        }

        private static int[] SortInIncreasingOrder(int[] numbers)
        {
            int[] increasingArray = SortInDescendingOrder(numbers);
            Array.Reverse(increasingArray);
            return increasingArray;
        }

        private static void PrintArray(int[] numbers)
        {
            Console.WriteLine(new string('-', 70));
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 70));
        }

        private static int[] SortInDescendingOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int biggestNumberIndex = FindMaximal(numbers, i);
                int temp = numbers[biggestNumberIndex];
                numbers[biggestNumberIndex] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        private static int FindMaximal(int[] numbers, int startSearch)
        {
            int temp = startSearch;
            for (int i = startSearch; i < numbers.Length; i++)
            {
                if (numbers[temp] < numbers[i])
                {
                    temp = i;
                }
            }
            return temp;
        }
    }
}
