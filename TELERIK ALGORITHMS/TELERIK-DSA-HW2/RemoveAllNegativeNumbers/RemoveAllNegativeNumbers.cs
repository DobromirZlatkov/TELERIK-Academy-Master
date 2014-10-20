using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllNegativeNumbers
{
    class RemoveAllNegativeNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { -2, 11, -4, 123, 2, -55, 1 };

            var descendingOrderedNumbers = numbers.OrderByDescending(i => i).ToList();


            for (int i = descendingOrderedNumbers.Count - 1; i >= 0 ; i--)
            {
                if (descendingOrderedNumbers[i] > 0)
                {
                    break;
                }
                descendingOrderedNumbers.RemoveAt(i);
            }


            for (int i = 0; i < descendingOrderedNumbers.Count; i++)
            {
                Console.WriteLine(descendingOrderedNumbers[i]);
            }
        }
    }
}
