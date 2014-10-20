using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberOfTimes
{
    class OddNumberOfTimes
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>() { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> numberWithAppearance = new Dictionary<string, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!numberWithAppearance.ContainsKey(numbers[i]))
                {
                    numberWithAppearance[numbers[i]] = 0;
                }
                numberWithAppearance[numbers[i]] += 1;
            }

            foreach (var item in numberWithAppearance)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
