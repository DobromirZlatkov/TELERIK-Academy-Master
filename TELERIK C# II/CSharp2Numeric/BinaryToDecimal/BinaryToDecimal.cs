using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            /*Write a program to convert binary numbers to 
             * their decimal representation.
            */
            int couter = 0;
            Console.WriteLine("Enter binary number");
            string binary = Console.ReadLine();
            int numasDecimal = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    numasDecimal += (int)Math.Pow(2, couter);
                }
                couter++;
            }
            Console.WriteLine(numasDecimal);
        }
    }
}
