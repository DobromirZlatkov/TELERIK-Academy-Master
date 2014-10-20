using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLEttersFromAtoZ
{
    class AllLEttersFromAtoZ
    {
        static void Main(string[] args)
        {
            /*Write a program that creates an array containing all 
             * letters from the alphabet (A-Z). Read a word from the
             * console and print the index of each of its letters in
             * the array.
            */

            Console.WriteLine("Enter word");
            Console.WriteLine("No main letters allowed ;]");
            string word = Console.ReadLine();

            char[] lettersArray = new char[26];

            int start = 97;//(char) 97 = a;

            for (int i = 0; i < lettersArray.Length; i++)
            {
                lettersArray[i] = (char)start;
                start++;
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Possition of the letters are : ");
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < lettersArray.Length; j++)
                {
                    if (word[i] == lettersArray[j])
                    {
                        Console.Write(j + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }
    }
}
