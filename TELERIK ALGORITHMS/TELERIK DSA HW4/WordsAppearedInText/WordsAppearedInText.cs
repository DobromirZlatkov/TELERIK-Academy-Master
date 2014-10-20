using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WordsAppearedInText
{
    class WordsAppearedInText
    {
        static void Main(string[] args)
        {
           // string text = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
            
            StreamReader myFile = new System.IO.StreamReader("..\\..\\input.txt");
            using (myFile)
            {
                string text = myFile.ReadToEnd();


                var words = text.Split((new Char[] { ' ', ',', '.', ':', '!', '?', '–', '_', ')', '(', '"' }), StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, int> numberWithAppearance = new Dictionary<string, int>();

                for (int i = 0; i < words.Length; i++)
                {
                    if (!numberWithAppearance.ContainsKey(words[i].ToLower()))
                    {
                        numberWithAppearance[words[i].ToLower()] = 0;
                    }
                    numberWithAppearance[words[i].ToLower()] += 1;
                }

                var orderedWords = numberWithAppearance.OrderBy(w => w.Value);

                foreach (var item in orderedWords)
                {
                    Console.WriteLine("{0} ---> {1} times", item.Key, item.Value);
                }
            } 
        }
    }
}
