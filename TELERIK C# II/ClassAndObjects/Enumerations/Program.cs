using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };
        static void Main(string[] args)
        {

            Day day = Day.Monday;
            Console.WriteLine(day);


            Day nextDay = day + 1;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(nextDay);

            Day thirdDay = (Day)3;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(thirdDay);

            string sundayStr = "Sunday";

            Day sunday = (Day) Enum.Parse(typeof(Day), sundayStr);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(sunday);

            Console.ResetColor();
        }
    }
}
