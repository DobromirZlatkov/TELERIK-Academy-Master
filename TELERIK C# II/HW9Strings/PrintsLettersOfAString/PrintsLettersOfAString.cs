using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsLettersOfAString
{
    class PrintsLettersOfAString
    {
        /*Write a program that reads a string from the console
         * and prints all different letters in the string along 
         * with information how many times each letter is found. 
        */
        static void Main(string[] args)
        {
           // string text = "aaabbbccc ddd g";
            string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. ";
            char[] letters = LoadCharArray();
            CountLetters(text, letters);
        }

        private static char[] LoadCharArray()
        {
            char[] array = new char[27];
            int j = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                array[j] = i;
                j++;
            }
            return array;
        }

        private static void CountLetters(string text, char[] letters)
        {
            text = text.ToLower();
            for (int i = 0; i < letters.Length; i++)
            {
                
                var count = text.Count(x => x == letters[i]);
                if (count > 0)
                {
                    Console.Write(letters[i] + " : ");
                    Console.WriteLine(count);
                }
                
            }
            
        }
    }
}
