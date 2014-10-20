using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentenceWithWord
{
    /*Write a program that extracts from a given text all 
     * sentences containing given word.
		Example: The word is "in". The text is:
     * 
        We are living in a yellow submarine. We don't have anything else. 
     *  Inside the submarine is very tight. So we are drinking all
     *  the day. We will move out of it in 5 days.  
     *  
		The expected result is:
        We are living in a yellow submarine.
        We will move out of it in 5 days.
     * 
		Consider that the sentences are separated by "." and the words – by
     *  non-letter symbols.
    */
    class ExtractSentenceWithWord
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight in. So we are drinking all the day. We will move out of it IN 5 days.";
            string specialWord = "in";
            string[] sentances = text.Split('.');

            for (int i = 0; i < sentances.Length; i++)
            {
                for (int j = 0; j < sentances[i].Length; j++)
                {

                    string[] words = sentances[i].Split(' ');
                    for (int k = 0; k < words.Length; k++)
                    {
                        if (words[k].ToLower() == specialWord)
                        {
                            Console.WriteLine(sentances[i]);
                            j = sentances[i].Length - 1;
                            break;
                        }
                    }                   
                }
            }
        }
    }
}
