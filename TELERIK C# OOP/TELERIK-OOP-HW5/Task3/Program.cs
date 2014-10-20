using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintNumber();
                PrintDate();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintDate()
        {
            DateTime start = new DateTime(2000, 1, 1);
            DateTime end = new DateTime(2010, 1, 1);
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>(start, end);
            }
            else
            {
                Console.WriteLine("Date is valid");
            }
        }

        private static void PrintNumber()
        {
            int start = 0;
            int end = 1000;
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(start, end);
            }
            else
            {
                Console.WriteLine("Number is valid");
            }
        }
    }
}
