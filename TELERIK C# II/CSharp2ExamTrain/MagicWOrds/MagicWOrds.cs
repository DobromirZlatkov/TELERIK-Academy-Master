using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWOrds
{
    class MagicWOrds
    {

        private static List<string> Intput()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            for (int i = 0; i < n; i++)
            {
                input.Add(Console.ReadLine());
            }
            return input;
        }

        private static string PrintAlgorytm(List<string> input)
        {
            StringBuilder result = new StringBuilder();

            int largestString = FindLargest(input);
            int counter = 0;
            for (int j = 0; j < largestString; j++)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i].Length <= counter)
                    {
                        continue;
                    }
                    
                    result.Append(input[i].Substring(counter, 1));                       
                     
                }
                 counter++;
            }
           
            return result.ToString();
        }

        private static int FindLargest(List<string> input)
        {
            int result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (result < input[i].Length)
                {
                    result = input[i].Length;
                }
            }
            return result;
        }        



        static void Main(string[] args)
        {
            List<string> input = Intput();

            input = ReorderWords(input);         
            string result = PrintAlgorytm(input);
            Console.WriteLine(result);
        }

        private static List<string> ReorderWords(List<string> input)
        {
            //string[] input = new string[input.Length];

            for (int i = 0; i < input.Count; i++)
            {
                int poss = input[i].Length % (input.Count + 1);
                //temp[poss] = input[i];

                input.Insert(poss, input[i]);
                if (poss < i)
                {
                    input.RemoveAt(i + 1);
                }
                else
                {
                    input.RemoveAt(i);
                }

            }

            return input;
        }

       
    }
}
