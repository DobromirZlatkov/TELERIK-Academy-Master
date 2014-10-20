using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SubSetSUm__
{
    class Program
    {
        static void Main(string[] args)
        {

            /*We are given an array of integers and a number S. 
             * Write a program to find if there exists a subset of 
             * the elements of the array that has a sum S. Example:
            */

            Console.WriteLine("Enter array lenght");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sum S:");
            BigInteger S = BigInteger.Parse(Console.ReadLine());
            List<BigInteger> numbers = new List<BigInteger>();
            Console.WriteLine("Enter numbers to fill the array");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(BigInteger.Parse(Console.ReadLine()));
            }


            int counter = 0;
            string subsetSum = "";

            for (int i = 1; i < Math.Pow(2 , n); i++)
            {
                subsetSum = "";
                BigInteger sum = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int bit = iAndMask >> j;
                    if (bit == 1)
                    {
                        sum += numbers[j];
                        subsetSum = subsetSum + " " + numbers[j];
                    }
                }

                if (sum == S)
                {
                    Console.WriteLine(new string('-', 50));
                    counter++;
                    Console.WriteLine("subset has a sum of {0} - {1} ", S, subsetSum);
                    Console.WriteLine(new string('-', 50));
                }
            }

        }
    }
}
