﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalHexaPercentage
{
    class DecimalHexaPercentage
    {
        /*Write a program that reads a number and prints 
         * it as a decimal number, hexadecimal number, 
         * percentage and in scientific notation. 
         * Format the output aligned right in 15 symbols.
        */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
