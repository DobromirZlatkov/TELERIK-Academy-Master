using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace ReadListOfWords
{
    class ReadListOfWords
    {
        /*Write a program that reads a list of words from a file words.txt
         * and finds how many times each of the words is contained in another 
         * file test.txt. The result should be written in the file result.txt 
         * and the words should be sorted by the number of their occurrences
         * in descending order. Handle all possible exceptions in your methods.
        */
        static void Main(string[] args)
        {
            try
            {
                string wordsToRead = "words.txt";
                string wordsToCOunt = "text.txt";
                string result = "result.txt";
                List<string> words = LoadWordsFromText(wordsToRead);
                string[] wordsAsArray = words.ToArray();
                int[] counter = LoadWithCounts(wordsToCOunt, words);           
                Array.Sort(counter, wordsAsArray);
                WriteResult(wordsAsArray, counter, result);

                StreamReader reader = new StreamReader(result);
                using (reader)
                {
                    string read = reader.ReadToEnd();
                    Console.WriteLine(read);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private static void WriteResult(string[] wordsAsArray, int[] counter, string result)
        {
            StreamWriter writer = new StreamWriter(result);
            using (writer)
            {
                for (int i = 0; i < counter.Length; i++)
                {
                    writer.WriteLine(counter[i] + " = " + wordsAsArray[i]);
                }
            }
        }

        private static int[] LoadWithCounts(string wordsToCOunt, List<string> words)
        { 
            int[] counter = new int[words.Count];
            int count = 0;
            using (StreamReader reader = File.OpenText("test.txt"))
            { 
                string contents = reader.ReadToEnd();
                for (int i = 0; i < words.Count; i++)
                {                   
                    MatchCollection matches = Regex.Matches(contents, @"\b" + words[i] + @"\b");
                    count = matches.Count;
                    counter[i] = count;
                }              
            }
            return counter;
        }
      
        private static List<string> LoadWordsFromText(string wordsToRead)
        {
            StreamReader reader = new StreamReader(wordsToRead);
            List<string> words = new List<string>();
            
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    words.Add(line);
                    line = reader.ReadLine();
                }
            }           
            return words;
        }
    }
}
