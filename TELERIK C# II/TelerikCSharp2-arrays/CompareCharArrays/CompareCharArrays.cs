using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            /* Write a program that compares two char
             * arrays lexicographically (letter by letter).*/
            //strings as char arrays
            Console.WriteLine("Enter 2 string values:");
            string firstCharArray = Console.ReadLine();
            string secondCharArray = Console.ReadLine();

            int arrayLenght = 0;
            //takes smallest lenght
            if (firstCharArray.Length > secondCharArray.Length)
            {
                arrayLenght = secondCharArray.Length;
            }
            else if (firstCharArray.Length < secondCharArray.Length)
            {
                arrayLenght = firstCharArray.Length;
            }
            else
            {
                arrayLenght = secondCharArray.Length;
            }

            for (int i = 0; i < arrayLenght; i++)
            {
                if (firstCharArray[i] == secondCharArray[i])
                {
                    Console.WriteLine("char: {0} first array == char {1} second array-- on possition {2}", firstCharArray[i], secondCharArray[i], i);
                }
                else
                {
                    Console.WriteLine("char: {0} first array != char {1} second array-- on possition {2}", firstCharArray[i], secondCharArray[i], i);
                }
            }
        }
    }
}
