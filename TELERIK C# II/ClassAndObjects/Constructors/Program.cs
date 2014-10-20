using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    
    class Program
    {
        static Random globalrandomGenerator = new Random();


        static void Main(string[] args)
        {
            string s = new String(new char[] { 'a', 'b', 'c' });
            Console.WriteLine(s);

            DateTime dt = new DateTime(2009, 12, 30);
            Console.WriteLine(dt);
            DateTime dt2 = new DateTime(2009, 12, 30, 12, 33, 59);
            Console.WriteLine(dt2);
            Int32 value = new Int32();

            Random randomGenerator = new Random(123);
            Console.WriteLine(randomGenerator.Next());

            Random randomGenerator2 = new Random(456);
            Console.WriteLine(randomGenerator2.Next(50));

            Random randomGenerator1 = new Random();
            Console.WriteLine(randomGenerator1.Next());

            Random randomGenerator4 = new Random();
            Console.WriteLine(randomGenerator4.Next());
        }
    }
}
