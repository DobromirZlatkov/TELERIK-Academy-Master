using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TextFileContainingListOFStrings
{
    class TextFileContainingListOFStrings
    {
        /*Write a program that reads a text file containing a list of
         * strings, sorts them and saves them to another text file.
         * Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
*/
        // all text files are in directory where is .cs
        static void Main(string[] args)
        {
            List<string> lines = TakeNamesFromString();
            lines.Sort();
            Console.WriteLine(new string('-', 50));
            RewriteFile(lines);
            
        }

        private static void RewriteFile(List<string> lines)
        {
            StreamWriter writer = new StreamWriter("output.txt");
            for (int i = 0; i < lines.Count; i++)
            {
                writer.WriteLine(lines[i]);
                Console.WriteLine(lines[i]);
            }
            Console.WriteLine("File Writen Succesfully");
        }

        private static List<string> TakeNamesFromString()
        {
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader("input.txt");
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                    Console.WriteLine(line);
                }
            }
            return lines;
            
        }
    }
}
