using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCombinationsWithoutDublicates
{
    class AllCombinationsWithoutDublicates
    {
        internal static void Main()
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());

            if (!(0 < k && k <= n))
            {
                throw new InvalidOperationException();
            }

            Combinate(0, n, k, new int[k]);
        }

        private static void Combinate(int p, int n, int k, int[] arr)
        {
            if (p == k)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            }

            int num = (p == 0) ? 1 : arr[p - 1] + 1;
            for (; num <= n; num++)
            {
                arr[p] = num;
                Combinate(p + 1, n, k, arr);
            }
        }
    }
}
