using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlgorithm
{
    class QuickSortAlgorithm
    {
        static void Main(string[] args)
        {
            /*Write a program that sorts an array of strings using the
             * quick sort algorithm (find it in Wikipedia).
             http://www.youtube.com/watch?v=y_G9BkAm6B8*/

            Console.WriteLine("Enter array lenght");
            int n = int.Parse(Console.ReadLine());

            List<string> stringArray = new List<string>();
            Console.WriteLine("Enter strings");
            for (int i = 0; i < n; i++)
            {
                stringArray.Add(Console.ReadLine());
            }

            for (int i = 0; i < stringArray.Count; i++)
            {
                int pivot = i;

                for (int j = 0; j < stringArray.Count; j++)
                {
                    if ((stringArray[j].Length < stringArray[pivot].Length && j > pivot)
                        || (stringArray[j].Length > stringArray[pivot].Length && j < pivot))
                    {
                        string temp = "";
                        temp = stringArray[j];
                        stringArray[j] = stringArray[pivot];
                        stringArray[pivot] = temp;
                        pivot = i;

                    }
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Sorted array");
            for (int i = 0; i < stringArray.Count; i++)
            {
                Console.WriteLine(stringArray[i] + " ");
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
