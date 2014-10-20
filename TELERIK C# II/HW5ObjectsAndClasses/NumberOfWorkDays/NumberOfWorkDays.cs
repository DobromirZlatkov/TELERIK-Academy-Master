using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWorkDays
{
    class NumberOfWorkDays
    {
        static void Main(string[] args)
        {
            /*Write a method that calculates the number of w
             * orkdays between today and given date, passed as 
             * parameter. Consider that workdays are all days 
             * from Monday to Friday except a fixed list of 
             * public holidays specified preliminary as array.
            */
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine("Enter date:");
            DateTime end = DateTime.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;

            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(currentYear, 1,1));
            holidays.Add(new DateTime(currentYear, 3,3));
            holidays.Add(new DateTime(currentYear, 5,1));
            holidays.Add(new DateTime(currentYear, 5,2));
            holidays.Add(new DateTime(currentYear, 5,6));
            holidays.Add(new DateTime(currentYear, 5,24));
            holidays.Add(new DateTime(currentYear, 9,22));
            holidays.Add(new DateTime(currentYear, 12,24));
            holidays.Add(new DateTime(currentYear, 12,25));
            holidays.Add(new DateTime(currentYear, 12,26));
            holidays.Add(new DateTime(currentYear, 12,31));


            int daysToCHeck = Math.Abs((end - today).Days);
            Console.WriteLine(daysToCHeck);

           int workingDays = CalculateWorkDays(holidays, daysToCHeck, today, end);
           Console.WriteLine("Working  days = {0}", workingDays);
        }

        private static int CalculateWorkDays(List<DateTime> holidays, int daysToCHeck, DateTime today, DateTime end)
        {
            int workingDays = 0;
            bool isHoliday = false;
            for (int i = 0; i < daysToCHeck; i++)
            {
                today = today.AddDays(1);
                
                if (today.DayOfWeek != DayOfWeek.Sunday && today.DayOfWeek != DayOfWeek.Saturday)
                {
                   
                    for (int j = 0; j < holidays.Count; j++)
                    {                       
                        if (today == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workingDays++;
                    }
                    isHoliday = false;
                }
               
            }
            return workingDays;
        }
    }
}
