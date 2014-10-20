
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryRepresentationOfShort
{
    class BinaryRepresentationOfShort
    {
        static void Main(string[] args)
        {
            /*Write a program that shows the binary representation
             * of given 16-bit signed integer number 
             * (the C# type short).
            */
            Console.WriteLine("Enter number");
            short n = short.Parse(Console.ReadLine());
            string nAsString = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine(nAsString);

            // second way
            string result = "";
            for (int i = 15; i >= 0; i--)
            {
                string bit = ((n >> i) & 1).ToString();
                result += bit;
            }
            Console.WriteLine(result);
        }
    }
}
