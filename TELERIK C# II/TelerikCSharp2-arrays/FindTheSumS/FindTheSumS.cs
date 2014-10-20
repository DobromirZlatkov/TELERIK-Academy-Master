using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSumS
{
    class FindTheSumS
    {
        static void Main(string[] args)
        {
            /*Write a program that finds in given array of integers a
                sequence of given sum S (if present). 
            Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

            Console.WriteLine("Enter array lenght");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sum S:");
            int S = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            // load array
            Console.WriteLine("Enter N numbers to fill the array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); 
            }
            int startIndex = 0;
            int endIndex = 0;
            int currentSum = 0;

            for (int i = 0; i < n; i++)
            {
                currentSum = numbers[i];
                for (int j = i+1; j < n; j++)
                {
                    if (currentSum == S)
                    {
                        startIndex = i;
                        endIndex = j - 1;
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("S sum is found between:{0} and {1} in the array ", startIndex, endIndex);
                        Console.Write("Numbers are: ");
                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            Console.Write(numbers[k] + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine(new string('-', 50));                        
                    }
                    if (currentSum > S || j == n)
                    {
                        break;
                    }
                    currentSum = currentSum + numbers[j];
                }
            }           
        }
    }
}
