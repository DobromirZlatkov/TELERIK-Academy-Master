﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateString
{
    class CalculateString
    {
        /*You are given a sequence of positive integer values written into a string, 
         * separated by spaces. Write a function that reads these values from given 
         * string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461
        */
        static void Main(string[] args)
        {
            string numbers = "43 68 9 23 318";
            string[] array = numbers.Split(' ');
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Convert.ToInt32(array[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
