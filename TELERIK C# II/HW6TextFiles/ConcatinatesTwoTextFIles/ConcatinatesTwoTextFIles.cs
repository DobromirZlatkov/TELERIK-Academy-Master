using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConcatinatesTwoTextFIles
{
    class ConcatinatesTwoTextFIles
    {
        /*Write a program that concatenates two text files 
         * into another text file.
        */
        // all text files are in directory where is .cs
        static void Main(string[] args)
        {
            string firstFile = @"firstFile.txt";
            string secondFile = @"secondFile.txt";
            
           
            StreamWriter concatinated = new StreamWriter("concatinated.txt");
            using (concatinated)
            {
                StreamReader firstReader = new StreamReader(firstFile);
                StreamReader secondReader = new StreamReader(secondFile);
                using (firstReader)
                {
                    
                    string first = firstReader.ReadToEnd();
                    Console.WriteLine("First file: ");
                    Console.WriteLine(first);
                    concatinated.WriteLine(first);
                }
                using (secondReader)
                {
                    Console.WriteLine(new string('-', 50));
                    string second = secondReader.ReadToEnd();
                    Console.WriteLine("Second file: ");
                    Console.WriteLine(second);
                    concatinated.WriteLine(second);
                }
            }
            // print result
            StreamReader concatinetedStream = new StreamReader("concatinated.txt");
            using (concatinetedStream)
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Concatinated FIles");
                string line = concatinetedStream.ReadToEnd();
                Console.WriteLine(line);
            }
        }
    }
}
