using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStOfKElements
{
    class SubStOfKElements
    {
        static void Main(string[] args)
        {
            /** Write a program that reads three integer numbers N, 
             * K and S and an array of N elements from the console.
             * Find in the array a subset of K elements that have sum 
             * S or indicate about its absence.*/

            Console.WriteLine("Enter N number of integers");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K number of elements");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter S sum we search");
            int S = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("Enter numbers in the array");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }


            string subsetNUmbers = "";
            int counter = 0;
            bool isASubsetWithK = false;
            for (int i = 1; i < Math.Pow(2,n); i++)
            {
                int sum = 0;
                subsetNUmbers = "";
                int kCounter = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int bit = iAndMask >> j;
                    if (bit == 1)
                    {
                        sum += numbers[j];
                        subsetNUmbers = subsetNUmbers + " " + numbers[j];
                        kCounter++;
                    }
                }
                if (sum == S && kCounter == K)
                {
                    Console.WriteLine(new string('-', 50));
                    isASubsetWithK = true;
                    counter++;
                    Console.WriteLine("subset with {2} elements has a sum of {0} - {1} ", S, subsetNUmbers, K);
                    Console.WriteLine(new string('-', 50));
                }
            }
            if (!isASubsetWithK)
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("NO subset with {0} elements found.", K);
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
