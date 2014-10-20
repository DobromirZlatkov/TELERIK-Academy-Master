using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {



            Dictionary<string, int> sencences = new Dictionary<string, int>();
            string searchWord = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] counters = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                
                string input = Console.ReadLine();
                string[] sentance = input.Split(new char[] { ' ',',', '.', '(', ')', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                CountWordsInCentance(searchWord, sencences, sentance, counters);
            }


            int j = 0;
            foreach (var item in sencences)
            {
                counters[j] = item.Value;
                j++;  
            }

            Array.Sort(counters);

            for (int i = counters.Length - 1; i >= 0; i--)
            {
                foreach (var item in sencences)
                {
                    if (item.Value == counters[i])
                    {
                        Console.WriteLine(item.Key);
                    }
                }
            }
        }

        private static void CountWordsInCentance(string searchWord, Dictionary<string, int> sencences, string[] sentance, int[] counters)
        {

            int counter = 0;
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < sentance.Length; j++)
            {
                if (sentance[j] == searchWord)
                {
                    counter++;
                    sentance[j] =  sentance[j].ToUpper();////
                    
                }
                sb.AppendFormat(sentance[j] + " ");
            }
            if (sb[sb.Length - 1] == ' ')
            {
                sb.Remove(sb.Length - 1, 1);
            }
            sencences.Add(sb.ToString(),counter);
        }
    }
}
