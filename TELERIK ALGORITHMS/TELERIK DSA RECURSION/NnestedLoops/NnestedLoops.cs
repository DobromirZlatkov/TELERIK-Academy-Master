using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NnestedLoops
{
    class NnestedLoops
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NestedLoops(0, n, new int[n]);
        }

        private static void NestedLoops(int i, int n, int[] arr)
        {
            if (i == n)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            }

            for (int num = 0; num <= n; num++)
            {
                arr[i] = num;
                NestedLoops(i + 1, n, arr);
            }           
        }
    }
}
