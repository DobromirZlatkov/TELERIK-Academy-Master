using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovesAllSequenceOddNumbers
{
    class RemovesAllSequenceOddNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            Dictionary<int, int> numbersCounts = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!numbersCounts.ContainsKey(numbers[i]))
                {
                    numbersCounts[numbers[i]] = 0;
                }

                numbersCounts[numbers[i]]++;
            }

            foreach (var number in numbersCounts)
            {
                if (number.Value % 2 != 0)
                {
                    numbers.RemoveAll(x => x == number.Key);
                }
            }

            var result = string.Join(", ", numbers);
            Console.WriteLine(result);
        }
    }
}
