using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ReverseWordInSentence
{
    class ReverseWordInSentence
    {
        /*Write a program that reverses the words
         * in given sentence.
	      Example: "C# is not C++, not PHP and
         * not Delphi!"  "Delphi not and PHP, 
         * not C++ not is C#!".
        */
        static void Main(string[] args)
        {
            string sentance = "C# is not C++, not PHP and not Delphi!";
            ReversWords(sentance);
        }

        private static void ReversWords(string sentance)
        {
            char[] separators = { '.', ',', ' ', '!', '?', ';', ':' };
            string[] words = sentance.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            string[] arr = Regex.Split(sentance, "[A-Za-z0-9#+]");
            List<string> nonLEtters = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != string.Empty)
                {
                    nonLEtters.Add(arr[i]);
                }
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < nonLEtters.Count; i++)
            {
                if (i < words.Length)
                {
                    result.Append(words[i]);
                }
                result.Append(nonLEtters[i]);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
