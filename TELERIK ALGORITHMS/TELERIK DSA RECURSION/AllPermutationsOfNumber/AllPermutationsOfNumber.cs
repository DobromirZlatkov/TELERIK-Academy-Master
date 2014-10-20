using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPermutationsOfNumber
{
    class AllPermutationsOfNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Permutate(0, n, new int[n], new bool[n]);
        }

        private static void Permutate(int p, int n, int[] arr, bool[] used)
        {
            if (p == n)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            }

            for (int num = 0; num < n; num++)
            {
                if (used[num])
                {
                    continue;
                }

                arr[p] = num + 1;
                used[num] = true;
                Permutate(p + 1, n, arr, used);
                used[num] = false;
            }
        }
    }
}
