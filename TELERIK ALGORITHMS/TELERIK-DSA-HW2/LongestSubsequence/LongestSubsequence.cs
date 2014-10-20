using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubsequence
{
    class LongestSubsequence
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 1, 2, 2, 2, 2, 1, 1, 4, 4, 4, 4, 4, 4 };
            List<int> longestSequence = FindLongestSequence(numbers);

            for (int i = 0; i < longestSequence.Count; i++)
            {
                Console.WriteLine(longestSequence[i]);
            }
        }

        private static List<int> FindLongestSequence(List<int> numbers)
        {
            List<int> result = new List<int>();
            int longestSequenceLength = 0;
            int numberFromTheSequence = 0;
            int max = 0;
            for (int i = 1; i < numbers.Count(); i++)
            {
                if (numbers[i-1] == numbers[i])
                {
                    longestSequenceLength++;
                }
                else
                {
                    longestSequenceLength = 1;
                }

                if (max < longestSequenceLength)
                {
                    max = longestSequenceLength;
                    numberFromTheSequence = numbers[i - 1]; 
                }
            }

            for (int i = 0; i < max; i++)
            {
                result.Add(numberFromTheSequence);
            }

            return result;
        }
    }
}
