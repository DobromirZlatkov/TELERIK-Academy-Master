using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllOrderedSubsets
{
    class AllOrderedSubSets
    {
        private static string[] set = new[] { "hi", "a", "b" };

        internal static void Main()
        {
            int n = set.Length;
            int k = 2;

            if (!(0 < k && k <= n))
            {
                throw new InvalidOperationException();
            }

            Variate(0, n, k, new int[k]);
        }

        private static void Variate(int p, int n, int k, int[] variation)
        {
            if (p == k)
            {
                Console.WriteLine("({0})", string.Join(", ", variation.Select(i => set[i])));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                variation[p] = i;
                Variate(p + 1, n, k, variation);
            }
        }
    }
}
