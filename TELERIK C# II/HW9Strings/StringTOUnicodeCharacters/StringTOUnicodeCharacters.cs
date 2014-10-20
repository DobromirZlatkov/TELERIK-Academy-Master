using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTOUnicodeCharacters
{
    class StringTOUnicodeCharacters
    {
        /*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
        Hi!
		Expected output:
        \u0048\u0069\u0021

        */
        static void Main(string[] args)
        {
            string text = "Hi!";
            StringTounicode(text);
        }
        private static void StringTounicode(string text)
        {
            foreach (var item in text)
            {
                Console.Write("\\u{0:X4}", (int)item);
            }
            Console.WriteLine();
        }
    }
}
