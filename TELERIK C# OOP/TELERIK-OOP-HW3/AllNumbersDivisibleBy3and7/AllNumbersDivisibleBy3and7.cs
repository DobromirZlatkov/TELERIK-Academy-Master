using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllNumbersDivisibleBy3and7
{
    /*Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/
    class AllNumbersDivisibleBy3and7
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            NumbersDivisibleBy3and7(array);
        }

        private static void NumbersDivisibleBy3and7(int[] array)
        {
            //with LAMBDA
            var divisibleBy3and7 = array.Where(num => num % 21 == 0).Select(num => num);
            //with LINQ
            var divisibleBy3and7LINQ =
                from num in array
                where num % 21 == 0
                select num;

            foreach (var item in divisibleBy3and7)
            {
                Console.WriteLine(item);
            }
        }
    }
}
