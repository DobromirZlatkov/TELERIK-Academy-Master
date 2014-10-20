using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            /*Write a program to convert binary numbers to 
             * hexadecimal numbers (directly).
            */

            Console.WriteLine("Enter binary number");
            string binaryNumber = Console.ReadLine();

            Console.WriteLine(BinToHex(binaryNumber)); 
        }

        private static string BinToHex(string binaryNumber)
        {
            int reminder = binaryNumber.Length % 4;
            if (reminder!=0)
            {
                binaryNumber = new string('0', 4 - reminder) + binaryNumber;
            }

            string hexNumber = "";

            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                string element = binaryNumber.Substring(i, 4);
                switch (element)
                {
                    case "1010": hexNumber += "A";
                        break;
                    case "1011": hexNumber += "B";
                        break;
                    case "1100": hexNumber += "C";
                        break;
                    case "1101": hexNumber += "D";
                        break;
                    case "1110": hexNumber += "E";
                        break;
                    case "1111": hexNumber += "F";
                        break;
                    default:
                        {
                            int power = element.Length - 1;
                            int temp = 0;
                            for (int j = 0; j < 4; j++)
                            {
                                temp += int.Parse(element[j].ToString()) * (int)(Math.Pow(2, power));
                                power--;
                            }
                            hexNumber += temp;
                        }
                        break;
                }
            }
            return hexNumber;
        }
    }
}
