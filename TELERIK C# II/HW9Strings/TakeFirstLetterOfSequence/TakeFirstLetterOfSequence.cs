using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeFirstLetterOfSequence
{
    class TakeFirstLetterOfSequence
    {
        /*Write a program that reads a string from the console
         * and replaces all series of consecutive identical
         * letters with a single one. Example:
         * "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
        */
        static void Main(string[] args)
        {
            string text = "aaaaabbbbbbcddddeeeeedsssaa";

            StringBuilder builder = new StringBuilder(text);

            for (int i = 0; i < builder.Length - 1; i++)
            {
                if (builder[i] == builder[i + 1])
                {
                    builder.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
