using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrayElements
{
    class CompareArrayElements
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two arrays from the console and compares them element by element.*/
            Console.WriteLine("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            Console.WriteLine("Enter numbers to fill first array:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter numbers to fill second array:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            // compare array elements 
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("first array value :{0} = {1}:second array value on possition {2}",firstArray[i], secondArray[i], i);
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("first array value :{0} > {1}:second array value on possition {2}", firstArray[i], secondArray[i], i);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("first array value :{0} < {1}:second array value on possition {2}", firstArray[i], secondArray[i], i);
                }
            }

        }
    }
}
