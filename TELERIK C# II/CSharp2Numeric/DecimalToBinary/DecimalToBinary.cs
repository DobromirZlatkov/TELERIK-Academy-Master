using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            /*Write a program to convert decimal numbers to 
             * their binary representation.
            */

            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            //first way
            string nAsBynary = Convert.ToString(n, 2);            
            for (int i = nAsBynary.Length - 1; i >= 0; i--)
            {
                Console.Write(nAsBynary[i]);
            }
            Console.WriteLine();
            // second way
            while (n > 0)
            {
                int rest = n % 2;
                n /= 2;
                Console.Write(rest);
            }
            Console.WriteLine();
        }
    }
}
