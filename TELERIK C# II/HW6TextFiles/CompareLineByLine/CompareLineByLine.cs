using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CompareLineByLine
{
    class CompareLineByLine
    {
        /*Write a program that compares two text files line by line
         * and prints the number of lines that are the same and the
         * number of lines that are different. Assume the files have 
         * equal number of lines.
        */
        // all text files are in directory where is .cs
        static void Main(string[] args)
        {
            StreamReader first = new StreamReader("first.txt");
            StreamReader second = new StreamReader("second.txt");
           
            using (first)
            {
                using (second)
                {
                    int equal = 0;
                    int different = 0;
                    string firstLine = first.ReadLine();
                    string secondLine = second.ReadLine();

                    while (firstLine != null && secondLine != null)
                    {
                        Console.Write(firstLine + " : ");
                        Console.WriteLine(secondLine);
                        if (firstLine == secondLine)
                        {
                            equal++;  
                        }
                        else
                        {
                            different++;
                        }
                        secondLine = second.ReadLine();
                        firstLine = first.ReadLine();
                    } 
                    Console.WriteLine("Equal lines = {0}", equal);
                    Console.WriteLine("Different lines = {0}", different);
                }
                

            }
            
        }
    }
}
