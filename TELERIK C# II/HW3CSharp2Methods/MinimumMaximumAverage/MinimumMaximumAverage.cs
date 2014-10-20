using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumMaximumAverage
{
    class MinimumMaximumAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the array");
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Minimum element = {0}", CalcMinimum(numbers));
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Maximum element = {0}", CalcMaximum(numbers));
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Average element = {0}", CalcAverage(numbers));
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Sum of element = {0}", CalcSum(numbers));
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Product of element = {0}", CalcProduct(numbers));
            Console.WriteLine(new string('-', 70));
            
        }

        private static long CalcProduct(params int[] elements)
        {
            long product = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                product *= elements[i];
            }
            return product;
        }

        private static int CalcSum(params int[] elements)
        {
            int sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return sum;
        }

        private static decimal CalcAverage(params int[] elements)
        {
            decimal sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {

                sum += elements[i];
            }
            return sum / elements.Length;
        }

        private static int CalcMaximum(params int[] elements)
        {
            int temp = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (temp < elements[i])
                {
                    temp = elements[i];
                }
            }
            return temp;
        }

        private static int CalcMinimum(params int[] elements)
        {
            int temp = int.MaxValue;
            for (int i = 0; i < elements.Length; i++)
			{
			    if (temp > elements[i])
                {
                    temp = elements[i];
                }
			}
            return temp;
        }
    }
}
