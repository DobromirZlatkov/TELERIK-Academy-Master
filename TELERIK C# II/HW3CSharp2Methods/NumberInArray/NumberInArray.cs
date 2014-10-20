using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    class NumberInArray
    {
        static void Main(string[] args)
        {
            /*Write a method that counts how many times given number
             * appears in given array. Write a test program to check
             * if the method is working correctly.
            */

            Console.WriteLine("Enter array Length");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            Console.WriteLine("Enter numbers to fill the array");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Enter number to search");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("You have number {0}, {1} times in the array.",number ,ArrayCount(numbers, number)) ;

        }

        private static int ArrayCount(List<int> numbers, int number)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
