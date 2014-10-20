using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace DeleteAllWordsWithTest
{
    class DeleteTestPrefixwords
    {
        /*Write a program that removes from a text
         * file all words listed in given another text
         * file. Handle all possible exceptions in your
         * methods.
         */
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            PrintFile(fileName);
            Console.WriteLine(new string('-', 50));
            EditFile(fileName);
            PrintFile(fileName);
        }

        private static void EditFile(string fileName)
        {
            List<string> temp = new List<string>();
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                string line = reader.ReadLine();
                string pattern = "\\btest\\w*";
                while (line != null)
                {
                    Regex rgx = new Regex(pattern);
                    line = rgx.Replace(line, "");
                    temp.Add(line);
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter destinationFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    destinationFile.WriteLine(temp[i]);
                }
            }
        }

        private static void PrintFile(string newFileName)
        {
            using (StreamReader concatenated = new StreamReader(newFileName))
            {
                string line = concatenated.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = concatenated.ReadLine();
                }
            }
        }

    }
}

