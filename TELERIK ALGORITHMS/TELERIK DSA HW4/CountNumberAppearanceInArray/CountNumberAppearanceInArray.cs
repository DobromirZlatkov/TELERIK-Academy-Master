using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberAppearanceInArray
{
    class CountNumberAppearanceInArray
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>() { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> numberWithAppearance = new Dictionary<double, int>();

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
                Console.WriteLine("{0} ---> {1} times", item.Key, item.Value);
            }
        }


    }
}
