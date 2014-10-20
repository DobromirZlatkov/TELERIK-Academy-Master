using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyNumericSystem
{
    class AnyNumericSystem
    {
        static void Main(string[] args)
        {
            /*Write a program to convert from any numeral system of
             * given base s to any other numeral system of base d 
             * (2 ≤ s, d ≤  16).
            */
            
            Console.WriteLine("Enter 2 <= S");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 16 <= D");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number to convert");
            string number = Console.ReadLine();
            for (int i = ConvertToDsistem(ConverToDecimal(number, s),d).Length - 1; i >= 0; i--)
            {
                Console.Write(ConvertToDsistem(ConverToDecimal(number, s), d)[i]);
            }
            Console.WriteLine();
        }

        private static string ConvertToDsistem(int decimalNumber, int d)
        {
            string dNumeralSystem = "";
            if (d > 10)
            {
                while (decimalNumber > 0)
                {
                    string temp = (decimalNumber % d).ToString();
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
                    dNumeralSystem += temp;
                    decimalNumber /= d;
                }                
            }
            else
            {
                while (decimalNumber > 0)
                {
                    int rest = decimalNumber % d;
                    decimalNumber /= d;
                    dNumeralSystem += rest.ToString();
                }                
            }
            return dNumeralSystem;
        }

        private static int ConverToDecimal(string number, int s)
        {
            int decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > '9')
                {
                    decimalNumber += (number[i] - '7') * (int)(Math.Pow(s, (number.Length - 1 - i)));
                }
                else
                {
                    decimalNumber += (number[i] - '0') * (int)(Math.Pow(s, (number.Length - 1 - i)));
                }
            }
            return decimalNumber;
        }
    }
}
