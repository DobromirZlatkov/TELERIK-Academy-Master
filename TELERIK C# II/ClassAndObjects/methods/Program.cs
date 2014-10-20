using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleLower = "shalala";
            string sampleUpper = sampleLower.ToUpper();
            string substr = sampleLower.Substring(2, 4);

            Console.WriteLine(sampleLower);
            Console.WriteLine(sampleUpper);
            Console.WriteLine(substr);

            DateTime now = DateTime.Now;
            DateTime later = now.AddHours(8);

            Console.WriteLine(now);
            Console.WriteLine(later);
        }
    }
}
