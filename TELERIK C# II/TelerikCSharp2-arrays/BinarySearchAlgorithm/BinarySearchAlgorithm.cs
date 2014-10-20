using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlgorithm
{
    class BinarySearchAlgorithm
    {
        static void Main(string[] args)
        {
            /* Write a program that finds the index of given
             * element in a sorted array of integers by using the binary 
             * search algorithm (find it in Wikipedia).
            */
            Console.WriteLine("Enter array lenght");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number K that you want to find");
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter N numbers to fill the array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            // sorting the array
            Array.Sort(numbers);

            int arrayStart = 0;
            int arrayEnd = numbers.Length - 1;
            int arrayMiddle = 0;
            bool numberFound = false;
            

            while (arrayStart <= arrayEnd)
            {
                arrayMiddle = (arrayStart + arrayEnd) / 2;
                if (k == numbers[arrayMiddle])
                {
                    numberFound = true;
                    break;
                }
                else if (k < numbers[arrayMiddle])
                {
                    arrayEnd = arrayMiddle - 1;
                }
                else if (k > numbers[arrayMiddle])
                {
                    arrayStart = arrayMiddle + 1;
                }
            }
            Console.WriteLine(new string('-', 50));
            if (numberFound)
            {
                Console.WriteLine("Number {0} found! ", numbers[arrayMiddle]); 
            }
            else
            {
                Console.WriteLine("No such number in the array");
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
