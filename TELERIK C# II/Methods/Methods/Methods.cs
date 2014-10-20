using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{


    class ValidatingDemo
    {
        static void Main()
        {
            Console.WriteLine("What time is it?");

            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            // (The example continues on the next slide)

                bool isValidTime =
        ValidateHours(hours) &&
        ValidateMinutes(minutes);
            if (isValidTime)
                Console.WriteLine("It is {0}:{1}",
                  hours, minutes);
            else
                Console.WriteLine("Incorrect time!");
        }

        static bool ValidateMinutes(int minutes)
        {
            bool result = (minutes >= 0) && (minutes <= 59);
            return result;
        }

        static bool ValidateHours(int hours) { ... }
    }

}
