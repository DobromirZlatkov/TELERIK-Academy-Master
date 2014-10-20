using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2).PadLeft(64, '0');
            Console.WriteLine("num " + binary);

            for (int i = 0; i < 16; i++)
            {
                long firstMask = 1 << i;
                long secondMask = 1 << i + 1;
                long thirMask = 1 << i + 2;
                string binaryAs = Convert.ToString(firstMask, 2).PadLeft(64, '0');

                number ^= firstMask;
                Console.WriteLine("first bit " + binaryAs);
                //Console.WriteLine("first bit " + binaryAs);
                //Console.WriteLine("first bit " + binaryAs);
            }

            string binaryqwe = Convert.ToString(number, 2).PadLeft(64, '0');
            Console.WriteLine("num " + binaryqwe);
        }
    }
}
