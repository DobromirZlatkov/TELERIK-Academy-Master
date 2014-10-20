using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NumbersInfrontEachLine
{
    class NumbersInfrontEachLine
    {
        /*Write a program that reads a text file and inserts
         * line numbers in front of each of its lines. The result
         * should be written to another text file.
        */
        // all text files are in directory where is .cs
        static void Main(string[] args)
        {
            StreamReader readText = new StreamReader("text.txt");                        
            using (readText)
            {
                StreamWriter rewriteText = new StreamWriter("textWithNums.txt");
                using (rewriteText)
                {
                    string line = string.Empty;
                    int lineNumber = 0;

                    while ((line = readText.ReadLine()) != null)
                    {
                       lineNumber++;
                       rewriteText.WriteLine(lineNumber + " : " + line);                       
                    }
                }
                StreamReader readRewrite = new StreamReader("textWithNums.txt");
                using (readRewrite)
                {
                    string result = readRewrite.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
            
        }
    }
}
