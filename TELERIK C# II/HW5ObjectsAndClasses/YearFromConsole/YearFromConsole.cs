using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearFromConsole
{
    class YearFromConsole
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a year from
             * the console and checks whether it is 
             * a leap. Use DateTime.
            */

            Console.WriteLine("Enter year.");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Is year leap - {0}", IsLeapYear(year));
        }

        private static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
