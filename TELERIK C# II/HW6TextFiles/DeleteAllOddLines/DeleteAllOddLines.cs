using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DeleteAllOddLines
{
    class DeleteAllOddLines
    {
        /*Write a program that deletes from given text file all odd lines. 
         * The result should be in the same file.
        */
        // all text files are in directory where is .cs
        static void Main(string[] args)
        {
            string fileName = "textfile.txt";
            StreamWriter streamWriter = new StreamWriter(fileName);
            LoadFile(streamWriter);
            TakeOddLines(fileName);
            ReadFile(fileName);
        }

        private static void ReadFile(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            string result = streamReader.ReadToEnd();
            Console.WriteLine(result);
        }

        private static void TakeOddLines(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            List<string> oddLines = new List<string>();
            using (streamReader)
            {
                string line = streamReader.ReadLine();
                int lineCount = 0;
                while (line != null)
                {
                    if (lineCount % 2 == 0)
                    {
                        oddLines.Add(line);
                    }
                    line = streamReader.ReadLine();
                    lineCount++;
                }
            }

            StreamWriter loadFile = new StreamWriter(fileName);
            using (loadFile)
            {
                for (int i = 0; i < oddLines.Count; i++)
                 {
                     loadFile.WriteLine(oddLines[i]);
                 }
            }

        }

        private static void LoadFile(StreamWriter streamWriter)
        {
            using (streamWriter)
            {
                for (int i = 0; i < 100; i++)
                {
                    streamWriter.WriteLine(i);
                }
            }
        }
    }
}
