using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCombinations
{
    class StringCombinations
    {

        private static string[] set = new[] { "rock", "paper", "scissors", "lizard", "Spock" };

        internal static void Main()
        {
            int n = set.Length;
            int k = 3;

            if (!(0 < k && k <= n))
            {
                throw new InvalidOperationException();
            }

            Combinate(0, n, k, new int[k]);
        }

        private static void Combinate(int p, int n, int k, int[] comb)
        {
            if (p == k)
            {
                Console.WriteLine("({0})", string.Join(" ", comb.Select(x => set[x])));
                return;
            }

            int i = (p == 0) ? 0 : comb[p - 1] + 1;
            for (; i < n; i++)
            {
                comb[p] = i;
                Combinate(p + 1, n, k, comb);
            }
        }
    }
}
