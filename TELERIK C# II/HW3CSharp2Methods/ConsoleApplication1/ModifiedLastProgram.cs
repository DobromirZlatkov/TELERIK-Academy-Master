using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedLastProgram
{
    class ModifiedLastProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the array");

            // if you want to test change array type int, double, float, byte etc.
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Minimum element = {0}", CalcMinimum(numbers));//1, 2.2, 3, 4, -5, 6, 7
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Maximum element = {0}", CalcMaximum(numbers));//1, 2.2, 3, 4, -5, 6, 7
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Average element = {0}", CalcAverage(numbers));//1, 2.2, 3, 4, -5, 6, 7
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Sum of element = {0}", CalcSum(numbers));//1, 2.2, 3, 4, -5, 6, 7
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Product of element = {0}", CalcProduct(numbers));//1, 2.2, 3, 4, -5, 6, 7
            Console.WriteLine(new string('-', 70));

        }

        private static T CalcProduct<T>(params T[] elements)
        {
            dynamic product = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                product *= elements[i];
            }
            return product;
        }

        private static T CalcSum<T>(params T[] elements)
        {
            dynamic sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return sum;
        }

        private static decimal CalcAverage<T>(params T[] elements)
        {
            dynamic sum = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return (decimal)sum / elements.Length;
        }

        private static T CalcMaximum<T>(params T[] elements)
        {
            dynamic temp = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (temp < elements[i])
                {
                    temp = elements[i];
                }
            }
            return temp;
        }

        private static T CalcMinimum<T>(params T[] elements)
        {
            dynamic temp = elements[0];
            for (int i = 1; i < elements.Length; i++)
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
