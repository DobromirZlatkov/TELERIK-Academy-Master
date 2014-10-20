using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsInAlphabeticalOrder
{
    class WordsInAlphabeticalOrder
    {
        /*Write a program that reads a list of words,
         * separated by spaces and prints the list in
         * an alphabetical order.
        */
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
