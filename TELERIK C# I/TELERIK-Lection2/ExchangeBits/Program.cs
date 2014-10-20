using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeBits
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
       
            for (int i = 63; i > 0; i--)
            {
                long firstbit = ((long)num >> i) & 1;
                long secondtBit = ((long)num >> i - 1) & 1;
                long thirdBit = ((long)num >> i - 2) & 1;

                if (firstbit == secondtBit && secondtBit == thirdBit)
                {
                    ulong firstMask = (ulong)1 << i;
                    ulong secondMask = (ulong)1 << i - 1;
                    ulong thirdMask = (ulong)1 << i - 2;
                    num = num ^ firstMask;
                    num = num ^ secondMask;
                    num = num ^ thirdMask;
                    i -= 2;

                }
            }
        }
    }
}
