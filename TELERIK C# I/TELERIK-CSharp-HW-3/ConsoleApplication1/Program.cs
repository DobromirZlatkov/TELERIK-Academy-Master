using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 7 << p;
            int firstThree = n & mask;
            n = n & (~mask);

            //Console.WriteLine(Convert.ToString(firstThree, 2).PadLeft(32, '0'));
            p = 24;
            mask = 7 << p;
            int lastThree = n & mask;
            n = n & (~mask);

            //Console.WriteLine(Convert.ToString(lastThree, 2).PadLeft(32, '0'));
            firstThree = firstThree << 21;
            lastThree = lastThree >> 21;
            int changed = firstThree | lastThree;

            n = n | changed;
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            
        }
    }
}
