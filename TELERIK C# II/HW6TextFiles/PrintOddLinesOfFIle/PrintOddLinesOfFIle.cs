using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PrintOddLinesOfFIle
{
    class PrintOddLinesOfFIle
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a text file and prints 
             * on the console its odd lines.
            */
            // all text files are in directory where is .cs
            string fileName = "textfile.txt";
            StreamWriter streamWriter = new StreamWriter(fileName);

            using (streamWriter)
            {
                for (int i = 0; i < 100; i++)
                {
                    streamWriter.WriteLine(i);
                }
            }
            Console.WriteLine("File is written with numbers from 1 to 200!");
            string fileReadname = @"textfile.txt";

            StreamReader streamReader = new StreamReader(fileReadname);
            using (streamReader)
            {
                int lineNumber = 0;
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = streamReader.ReadLine();
                }
            }

        }
    }
}
