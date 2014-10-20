using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReplacesAllOccurences
{
    /*Write a program that replaces all
     * occurrences of the substring "start"
     * with the substring "finish" in a text
     * file. Ensure it will work with large
     * files (e.g. 100 MB).
     */
    // all text files are in directory where is .cs
    class ReplacesAllOccurences
    {

        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("input.txt");
            GenerateLargeFile(writer);
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writerSecond = new StreamWriter("temp.txt");
            

            using (reader)
            {
                using (writerSecond)
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        string newLine = line.Replace("start", "finish");
                        writerSecond.WriteLine(newLine);
                    }
                }
            }
            File.Delete("input.txt");
            File.Move("temp.txt", "input.txt");

            StreamReader readResult = new StreamReader("input.txt");
            using (readResult)
            {
                string result = readResult.ReadToEnd();
                Console.WriteLine(result);
            }
        }
        // fill file with "start123" words
        private static void GenerateLargeFile(StreamWriter writer)
        {
            using (writer)
            {
                long fileSize = 0;
                long maxSize = 1000;

                while (fileSize < maxSize)
                {
                    writer.WriteLine("start123");
                    FileInfo file = new FileInfo("input.txt");
                    fileSize = file.Length;
                }               
            }
        }
    }
}
