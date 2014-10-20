﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumberMethod
{
    class ReadNumberMethod
    {
        /*Write a method ReadNumber(int start, int end) that enters
         * an integer number in given range [start…end]. If an 
         * invalid number or non-number text is entered, the method 
         * should throw an exception. Using this method write a 
         * program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
        */
        static int counter = 0;
        static void Main(string[] args)
        {
            ReadNumber(1, 100);
        }

        private static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                Console.Write("Enter {2} number between {0} and {1}: ", start, end, ReturnTextFromNumber(counter + 1));
                number = int.Parse(Console.ReadLine());
                counter++;

                if (counter == 10)
                {
                    return number;
                }

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
                return 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number is out of range!");
                return 0;
            }

            return ReadNumber(number, end);
        }

        private static object ReturnTextFromNumber(int number)
        {
            string result = string.Empty;

            switch (number)
            {
                case 1:
                    result = "first"; 
                    break;

                case 2: 
                    result = "second";
                    break;
                case 3:
                    result = "third";
                    break;
                case 4:
                    result = "forth"; 
                    break;
                case 5: 
                    result = "fifth";
                        break;
                case 6: 
                    result = "sixth"; 
                    break;
                case 7:
                    result = "seventh"; 
                    break;
                case 8: 
                    result = "eight"; 
                    break;
                case 9: 
                    result = "ninth"; 
                    break;
                case 10: 
                    result = "tenth"; 
                    break;
            }

            return result;
        }
    }
}