using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace HowManyTImesWordIsMEt
{
    class HowManyTImesWordIsMEt
    {
        /*Write a program that reads a string from the console
         * and lists all different words in the string along
         * with information how many times each word is found.
        */
        static void Main(string[] args)
        {
            string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
            text = text.ToLower();
            string[] words = text.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (dictionary.ContainsKey(words[i]))
                {
                    dictionary[words[i]]= dictionary[words[i]]+ 1;
                }
                else
                {
                    dictionary.Add(words[i], 1);
                }
            }
            foreach (var word in dictionary)
            {
                Console.WriteLine("{0,-12} : {1}", word.Key, word.Value);
            }
        }
    }
}
