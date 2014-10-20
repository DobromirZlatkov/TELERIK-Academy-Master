using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class Zerg
    {
        static int convert(string currentDigit)
        {
            switch (currentDigit)
            {
                  case "Rawr": return 0;
                  case "Rrrr": return 1;
                  case "Hsst": return 2;
                  case "Ssst": return 3;
                  case "Grrr": return 4;
                  case "Rarr": return 5;
                  case "Mrrr": return 6;
                  case "Psst": return 7;
                  case "Uaah": return 8;
                  case "Uaha": return 9;
                  case "Zzzz": return 10;
                  case "Bauu": return 11;
                  case "Djav": return 12;
                  case "Myau": return 13;
                  case "Gruh": return 14;
                default: return -1;
                      
            }
           
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numberAs15cimal = new List<int>();
            for (int i = 0; i < input.Length; i+=4)
            {
                string currentDigit = input.Substring(i, 4);
                numberAs15cimal.Add(convert(currentDigit));
            }
            Console.WriteLine(ConvertToDecimal(numberAs15cimal));
        }

        private static long ConvertToDecimal(List<int> numberAs15cimal)
        {
            long result = 0;
            int j = 0;
            for (int i = numberAs15cimal.Count - 1; i >=0; i--)
            {
                long power = (long)Math.Pow(15, j);
                result += numberAs15cimal[i] * power;
                j++;
            }
            return result;
        }
    }
}
