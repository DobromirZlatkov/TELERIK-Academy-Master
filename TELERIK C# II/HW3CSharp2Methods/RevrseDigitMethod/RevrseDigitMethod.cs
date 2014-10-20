using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevrseDigitMethod
{
    public class RevrseDigitMethod
    {
        static void Main(string[] args)
        {

            /*Write a method that reverses the digits of given
             * decimal number. Example: 256  652
            */
            Console.WriteLine("Enter decimal number to reverse its digits");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Reversed number = {0}", ReverseDigits(number));
            Console.WriteLine(new string('-', 70));
        }

        public static string ReverseDigits(decimal number)
        {
            if (number < 0)
            {
                number = -number;
            }
            string numberAsString = Convert.ToString(number);
            char[] numberAsChars = numberAsString.ToCharArray();
            Array.Reverse(numberAsChars);
            string result = "";
            for (int i = 0; i < numberAsChars.Length; i++)
            {
                result += numberAsChars[i];
            }
            
            return result.TrimStart('0');
        }
    }
}
