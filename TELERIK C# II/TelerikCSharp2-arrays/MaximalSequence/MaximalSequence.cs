using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal
            //sequence of equal elements in an array.

            Console.WriteLine("Enter array lenght");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integers to fill the array");
            int[] array = new int[n];
            //load the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            // search for equal elements
            int equalElementsCount = 1;
            int temp = 0;
            int elementValue = 0;
            for (int i = 1; i < array.Length; i++)
            {                
                if (array[i] == array[i - 1])
                {
                    equalElementsCount++;
                }
                
                if (equalElementsCount > temp)
                {
                    temp = equalElementsCount;
                    elementValue = array[i];
                } 
                else
                {
                    equalElementsCount = 1;
                }
            }
            Console.WriteLine("Maximal sequence is:{0}", temp);
            Console.WriteLine("Value of the sequence is:{0}", elementValue);
        }
    }
}
