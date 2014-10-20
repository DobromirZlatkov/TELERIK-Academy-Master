using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            /*Write a program to convert decimal numbers to
             * their hexadecimal representation.
            */

            Console.WriteLine("Enter decimal number");
            int n = int.Parse(Console.ReadLine());
            string hexaDecimal = "";           
            while (n > 0)
            {
                string temp = (n % 16).ToString();                
                switch (temp)
                {
                    case "10":
                        temp = "A";
                        break;
                    case "11":
                        temp = "B";
                        break;
                    case "12":
                        temp = "C";
                        break;
                    case "13":
                        temp = "D";
                        break;
                    case "14":
                        temp = "E";
                        break;
                    case "15":
                        temp = "F";
                        break;
                    default:
                        break;
                }
                hexaDecimal += temp;
                n /= 16;
            }
            hexaDecimal += "x0";
            for (int i = hexaDecimal.Length - 1; i >= 0; i--)
            {
                Console.Write(hexaDecimal[i]);
            }
            Console.WriteLine();
        }
    }
}
