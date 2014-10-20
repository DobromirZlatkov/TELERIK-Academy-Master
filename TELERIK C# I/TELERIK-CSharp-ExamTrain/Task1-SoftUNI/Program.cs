using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_SoftUNI
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            double numberOfHolydays = int.Parse(Console.ReadLine());
            double numberOfWeekendsHome = int.Parse(Console.ReadLine());

            double normalWeekEnds = 48 - numberOfWeekendsHome;
            double normalWeekEndsPlays = (normalWeekEnds * 3) / 4;
            double holydaysPlays = (numberOfHolydays * 2) / 3;
            double result = normalWeekEndsPlays + holydaysPlays + numberOfWeekendsHome;
      
            if (typeOfYear == "leap")
            {
                result += (15 * result) / 100;
            }

            Console.WriteLine((int)result);
        }
    }
}
