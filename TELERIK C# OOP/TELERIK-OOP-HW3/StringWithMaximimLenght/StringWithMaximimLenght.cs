using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWithMaximimLenght
{
    class StringWithMaximimLenght
    {
        static void Main(string[] args)
        {
            string[] strings = new string[]
            {
                "a","aa","aaa","baaab","baaab","aaabbaaaaa","aaaa"
            };

            GetTheLargestStringWithLINQ(strings);
        }

        private static void GetTheLargestStringWithLINQ(string[] strings)
        {
            var largestString =
               ( from str in strings
                orderby str.Length descending
                select str).ElementAt(0);
            foreach (var item in largestString)
            {
                Console.Write(item);                
            }
            Console.WriteLine();
        }
    }
}
