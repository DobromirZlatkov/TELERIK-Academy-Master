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
            /*Write a program that reads two numbers N and K and 
             * generates all the combinations of K distinct 
             * elements from the set [1..N]. Example:
	        N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, 
             * {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

             */
            Console.WriteLine("Enter K:");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N:");
            int N = int.Parse(Console.ReadLine());
            int[] vector = new int[K];
            
            Gen01(K - 1, vector, N, 1);
        }     

        private static void Gen01(int K, int[] vector, int N, int start)
        {
            if (K < 0)
            {
                for (int i = vector.Length-1; i >=0; i--)
                {
                    Console.Write(vector[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = start; i <= N; i++)
                {
                    vector[K] = i;
                    Gen01(K - 1, vector, N, i+1);
                }
            }
        }
    }
}
