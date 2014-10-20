using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternelBynaryOfInt
{
    class InternelBynaryOfInt
    {
        static void Main(string[] args)
        {
            /** Write a program that shows the internal binary
             * representation of given 32-bit signed floating-point
             * number in IEEE 754 format (the C# type float). 
             * Example: -27,25  sign = 1, exponent = 10000011,
             * mantissa = 10110100000000000000000.
            */
            Console.WriteLine("Enter number");
            float number = float.Parse(Console.ReadLine());
            

            int firstHalf = TakeFirstHalfOfTheNumber(number);
            double secondHalf = TakeSecondHalfOfTheNumber(number);

            string firstHalfToBinary = ConvertToBinaryFirstPart(firstHalf);
            string secondHalfToBinary = ConvertToBinarySecondPart(secondHalf);

            string numberAsBinary = firstHalfToBinary + "." + secondHalfToBinary;
            
            int exponent = 127 + FindExponent(numberAsBinary);

            string normalyzeNumber = NormalyzeNumber(numberAsBinary);

            string mantisa = GetMantisaFromNormalizeNumber(normalyzeNumber);


            if (number > 0)
            {
               Console.WriteLine("sign = 0"); 
            }
            else if (number < 0)
            {
                Console.WriteLine("sign = 1"); 
            }
            Console.WriteLine("Exponent = {0}", Convert.ToString(exponent, 2));
            Console.WriteLine("Mantisa = {0}", mantisa);
        }

        private static string GetMantisaFromNormalizeNumber(string normalyzeNumber)
        {
            char[] array = new char[23];
            int j = 0;
            string result = string.Empty;
            for (int i = 2; i < normalyzeNumber.Length; i++)
            {
                array[j] = normalyzeNumber[i];
                j++;
            }
            for (int i = j; i < array.Length; i++)
            {
                array[i] = '0';
            }
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        private static string NormalyzeNumber(string numberAsBinary)
        {
            char[] array = numberAsBinary.ToCharArray();
            string result = string.Empty;
            char temp =' ';
            for (int i = array.Length-1; i >= 2; i--)
            {                
                if (array[i] == '.')
                {
                    temp = array[i-1];
                    array[i] = temp;
                    array[i - 1] = '.';                    
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        private static int FindExponent(string numberAsBinary)
        {
            char[] numberAsChars = numberAsBinary.ToCharArray();
            int exponent = 0;            
            for (int i = 1; i < numberAsChars.Length; i++)
            {
                if (numberAsChars[i] == '.')
                {
                    break;
                }
                exponent++;
            }
            return exponent;
        }

        private static string ConvertToBinarySecondPart(double secondHalf)
        {
            int end = 0;
            string secondHalfAsString = string.Empty;
            while (secondHalf > 0 && end < 23)
            {
                double temp = secondHalf * 2;
                int binary = (int)temp % 2;
                secondHalf = temp - binary;
                secondHalfAsString += binary.ToString();
                end++;
            }
            return secondHalfAsString;
        }

        private static string ConvertToBinaryFirstPart(int firstHalf)
        {
            firstHalf = Math.Abs(firstHalf);
            string firstHalfAsString = Convert.ToString(firstHalf, 2);
            return firstHalfAsString;
        }

        private static double TakeSecondHalfOfTheNumber(double number)
        {
            string numberAsString = number.ToString();
            string temp = string.Empty;

            for (int i = numberAsString.Length-1; i >= 0; i--)
            {
                if (numberAsString[i] == '.')
                {
                    break;
                }
                temp += numberAsString[i];
            }
            temp += ".0";
            temp = ReverseString(temp);
            double secondHalf = Convert.ToDouble(temp);
            return secondHalf;
        }

        private static string ReverseString(string temp)
        {
            char[] charArray = temp.ToCharArray();
            string reverse = string.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }

        private static int TakeFirstHalfOfTheNumber(float number)
        {
            string numberAsString = number.ToString();
            string temp = string.Empty;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                if (numberAsString[i] == '.')
                {
                    break;
                }
                temp += numberAsString[i];
            }
            int firstPart = Convert.ToInt32(temp);
            return firstPart;
        }

        
    }
}
