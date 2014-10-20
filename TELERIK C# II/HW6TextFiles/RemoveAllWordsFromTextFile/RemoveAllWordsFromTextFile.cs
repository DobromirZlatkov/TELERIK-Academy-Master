using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace RemoveAllWordsFromTextFile
{
    class RemoveAllWordsFromTextFile
    {
        static void Main(string[] args)
        {
            string textFile = "textFile.txt";
            string wordsToRemove = "words.txt";
            Console.WriteLine("Enter strings to fill text file. Write \"stop\" to end the cicle");            
            LoadTextFile(textFile);
            Console.WriteLine("Enter words to be removed from upper text. Write \"stop\" to end the cicle");
            Console.WriteLine(new string('-', 50));
            string result = "result.txt";
            try
            {
                LoadTextFile(wordsToRemove);
                RemoveWords(textFile, wordsToRemove);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
            }
            catch (UnauthorizedAccessException uoae)
            {
                Console.WriteLine(uoae.Message);
            }           
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            
            
            Console.WriteLine(ReadFIle(result));
        }

        private static string ReadFIle(string textFile)
        {
            StreamReader reader = new StreamReader(textFile);
            string result = reader.ReadToEnd();
            return result;
        }

        private static void RemoveWords(string textFile, string wordsToRemove)
        {
            List<string> words = new List<string>();
            StreamReader reader = new StreamReader(wordsToRemove);
            
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    words.Add(line);
                    line = reader.ReadLine();
                }
            }

            StreamReader reader2 = new StreamReader(textFile);
            
            using (reader2)
            {
                StreamWriter writer = new StreamWriter("result.txt");
                string line2 = reader2.ReadLine();
                using (writer)
                {                    
                    while (line2 != null)
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            string word = "\\b"+words[i]+"\\b";
                            line2 = Regex.Replace(line2, word, "");
                        }
                        writer.WriteLine(line2);
                        line2 = reader2.ReadLine();
                    }
                }
                
            }
        }

        private static void LoadTextFile(string textFile)
        {
            List<string> texts = new List<string>();
            string input = string.Empty;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                texts.Add(input);
            }
            StreamWriter writer = new StreamWriter(textFile);
            using (writer)
            {
                for (int i = 0; i < texts.Count; i++)
                {
                    writer.WriteLine(texts[i]);
                }
            }
        }
    }
}
