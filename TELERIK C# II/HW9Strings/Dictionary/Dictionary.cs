using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        /*A dictionary is stored as a sequence of text lines 
         * containing words and their explanations. Write a
         * program that enters a word and translates it by 
         * using the dictionary. Sample dictionary:
        */
        static void Main(string[] args)
        {
            string[] dictionaty = {".NET – platform for applications from Microsoft",
                                  "CLR – managed execution environment for .NET",
                                  "namespace – hierarchical organization of classes"};
            string word = "CLR";

            for (int i = 0; i < dictionaty.Length; i++)
            {
                if (dictionaty[i].Substring(0, word.Length) == word)
                {
                    Console.WriteLine((dictionaty[i]));
                    break;
                }
            }
        }
    }
}
