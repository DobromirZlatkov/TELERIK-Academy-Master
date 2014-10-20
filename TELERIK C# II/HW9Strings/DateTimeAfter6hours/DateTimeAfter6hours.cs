using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAfter6hours
{
    class DateTimeAfter6hours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date format dd.MM.yyyy HH:mm:ss");
            string str = Console.ReadLine();           
            DateTime date = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);           
            date = date.AddHours(6.5);           
            Console.WriteLine("{0} {1}",date, date.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
