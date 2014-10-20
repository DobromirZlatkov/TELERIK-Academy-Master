using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCombinationsWithDublicates
{
    class AllCombinationsWithDublicates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());

            Commbo(0, n, k, new int[k]);
        }

        private static void Commbo(int j, int n, int k, int[] arr)
        {
            if (j == k)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            int num = (j == 0) ? 1 : arr[j - 1];

            for (; num <= n; num++)
            {
                arr[j] = num;
                Commbo(j + 1, n, k, arr);
            }
        }
    }
}
