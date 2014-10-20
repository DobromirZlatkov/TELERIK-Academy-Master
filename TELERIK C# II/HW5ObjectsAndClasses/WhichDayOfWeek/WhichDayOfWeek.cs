using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichDayOfWeek
{
    class WhichDayOfWeek
    {
        static void Main(string[] args)
        {
            /*Write a program that prints to the console which day of the 
             * week is today. Use System.DateTime.
            */

            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek); 
        }
    }
}
