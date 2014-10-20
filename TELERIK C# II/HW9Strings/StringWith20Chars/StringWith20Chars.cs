using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWith20Chars
{
    class StringWith20Chars
    {
        /*Write a program that reads from the console a string 
         * of maximum 20 characters. If the length of the string 
         * is less than 20, the rest of the characters should be
         * filled with '*'. Print the result string into the console.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string < 20 chars");
            string s = Console.ReadLine();
            Console.WriteLine(FillStringWithAsterix(s));
        }

        private static string FillStringWithAsterix(string s)
        {
            s = s.PadRight(20, '*');
            return s;
        }
    }
}
