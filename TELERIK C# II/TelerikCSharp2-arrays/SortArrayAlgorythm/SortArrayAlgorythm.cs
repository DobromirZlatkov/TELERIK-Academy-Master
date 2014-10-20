using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayAlgorythm
{
    class SortArrayAlgorythm
    {
        static void Main(string[] args)
        {
            /*Sorting an array means to arrange its elements in 
             * increasing order. Write a program to sort an array.
             * Use the "selection sort" algorithm: Find the smallest
             * element, move it at the first position, find 
             * the smallest from the rest, move it at the second 
             * position, etc.
            */
            Console.WriteLine("Enter size of the array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            //load the array
            Console.WriteLine("Enter N numbers to load the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Array before arrangement");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            // arrange array
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array after arrangement");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }
    }
}
