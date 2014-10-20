using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitMethod
{
    class LastDigitMethod
    {
        static void Main(string[] args)
        {
            /*Write a method that returns the last digit of given
             * integer as an English word. Examples: 512  "two", 
             * 1024  "four", 12309  "nine".
            */

            Console.WriteLine("Enter integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Last digit is {0}", LastDigit(n));           
        }
        private static string LastDigit(int n)
        {
            int lastDigit = n % 10;

            switch (lastDigit)
            {
                case 0: return "zero";                    
                case 1: return "one";                    
                case 2: return "two";
                case 3: return "three";                    
                case 4: return "four";                    
                case 5: return "five";                   
                case 6: return "six";                   
                case 7: return "seven";                   
                case 8: return "eight";                    
                case 9: return "nine";
                default: return "Not valid input.";    
            }

        }
    }
}
