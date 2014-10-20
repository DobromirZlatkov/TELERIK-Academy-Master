using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMajorantOfAnArray
{
    class TheMajorantOfAnArray
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 2, 3, 3, 2, 3, 3, 3, 5 };

            var query = from i in numbers
                        group i by i into g
                        select new { g.Key, Count = g.Count() };

            foreach (var item in query)
            {
                if (item.Count >= numbers.Count / 2 + 1)
                {
                    Console.WriteLine(item.Key);
                    return;
                }
            }
            Console.WriteLine("No such number");
        }
    }
}
