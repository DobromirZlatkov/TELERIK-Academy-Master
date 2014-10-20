using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsTwoDates
{
    class ReadsTwoDates
    {
        /*Write a program that reads two dates in the format: 
         * day.month.year and calculates the number of 
         * days between them. Example:
         * Enter the first date: 27.02.2006
            Enter the second date: 3.03.2004
            Distance: 4 days

        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date - dd.mm.yyyy");
            string firstDate = Console.ReadLine();
            Console.WriteLine("Enter second date - dd.mm.yyyy");
            string secondDate = Console.ReadLine();

            string[] date1 = firstDate.Split('.');
            string[] date2 = secondDate.Split('.');

            DateTime start = new DateTime(int.Parse(date1[2]), int.Parse(date1[1]), int.Parse(date1[0]));
            DateTime end = new DateTime(int.Parse(date2[2]), int.Parse(date2[1]), int.Parse(date2[0]));
            Console.WriteLine("Days between = {0}",(end - start).TotalDays);

        }
    }
}
