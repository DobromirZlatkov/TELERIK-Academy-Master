using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits
{
    class Test
    {
        static void Main()
        {
            Bit64Array number = new Bit64Array(7);


            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Bit64Array number2 = new Bit64Array(7);

            Console.WriteLine(number.Equals(number2));

            Console.WriteLine(number[2]);

            Console.WriteLine(number.GetHashCode());

            number[4] = 1;

            Console.WriteLine(number.Number);
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
