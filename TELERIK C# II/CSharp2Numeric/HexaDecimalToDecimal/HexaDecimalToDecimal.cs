using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaDecimalToDecimal
{
    class HexaDecimalToDecimal
    {
        static void Main(string[] args)
        {
            /*Write a program to convert hexadecimal numbers to 
             * their decimal representation.
            */

            Console.WriteLine("Enter Hexadecimal number");
            string number = Console.ReadLine();
            int decimalResult = 0;
            int counter = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int nAsint;                
                if (Convert.ToInt32(number[i]) > 57)
                {
                    nAsint = (int)number[i] - 55;
                }
                else
                {
                    nAsint = Convert.ToInt32(number[i] - 48);
                }                
                int temp = nAsint * ((int)Math.Pow(16, counter));
                counter++;
                decimalResult += temp;
            }
            Console.WriteLine(decimalResult);
        }
    }
}
