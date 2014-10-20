using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfAppearances
{
    class NumberOfAppearances
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Dictionary<int, int> numbersCounts = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!numbersCounts.ContainsKey(numbers[i]))
                {
                    numbersCounts[numbers[i]] = 0;
                }

                numbersCounts[numbers[i]]++;
            }

            foreach (var item in numbersCounts)
            {
                Console.WriteLine("{0} --> {1} times", item.Key, item.Value);
            }
        }
    }
}
