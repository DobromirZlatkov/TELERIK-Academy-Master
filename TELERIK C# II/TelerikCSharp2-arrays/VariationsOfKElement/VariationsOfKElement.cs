using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvlojeniCikula
{
    class NvlojeniCikula
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two numbers N and K and generates 
             * all the variations of K elements from the set [1..N]. Example:
        	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, 
             * {3, 1}, {3, 2}, {3, 3}
             */
            Console.WriteLine("Enter K:");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N:");
            int N = int.Parse(Console.ReadLine());
            int[] vector = new int[K];
            Gen01(K - 1, vector, N);
        }

        private static void Gen01(int K, int[] vector, int N)
        {
            if (K < 0)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(vector[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    vector[K] = i;
                    Gen01(K - 1, vector, N);
                }
            }
        }
    }
}
