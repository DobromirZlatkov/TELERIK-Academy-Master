using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractPalidromes
{
    class ExtractPalidromes
    {
        /*Write a program that extracts from a given text all
         * palindromes, e.g. "ABBA", "lamal", "exe".
        */
        static void Main(string[] args)
        {
            string text = "palidromals are exe ABBA, lammal and paap .";
            string[] words = text.Split(' ', ',','.');
            IsWordPolindrom(words);
        }

        private static void IsWordPolindrom(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].SequenceEqual(words[i].Reverse()))
                {
                    Console.WriteLine(words[i]); 
                }                    
            }
        }
    }
}
