using System;
using System.IO;
using System.Text.RegularExpressions;
// all text files are in directory where is .cs
class ReplaceWordsOnly
{
    static void Main()
    {
         StreamWriter writerFirst = new StreamWriter("test.txt");
        GenerateLargeFile(writerFirst);
        StreamReader reader = new StreamReader("test.txt");


        StreamWriter writer = new StreamWriter("temp.txt");

        using (reader)
        {
            using (writer)
            {
                string pattern = @"\b(start)\b";
                Regex rgx = new Regex(pattern);

                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = rgx.Replace(line, "finish");
                    writer.WriteLine(newLine);
                }
            }
        }
        File.Delete("test.txt");
        File.Move("temp.txt", "test.txt");

        StreamReader readResult = new StreamReader("test.txt");
        using (readResult)
        {
            string result = readResult.ReadToEnd();
            Console.WriteLine(result);
        }
    }
             // fill file with "start123" + "start" words
    private static void GenerateLargeFile(StreamWriter writer)
    {
        using (writer)
        {
            long fileSize = 0;
            long maxSize = 1000;

            while (fileSize < maxSize)
            {
                writer.WriteLine("start123" + " " + "start");
                FileInfo file = new FileInfo("test.txt");
                fileSize = file.Length;
            }               
        }
    }
}
