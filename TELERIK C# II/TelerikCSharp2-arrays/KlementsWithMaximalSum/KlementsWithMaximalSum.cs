using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlementsWithMaximalSum
{
    class KlementsWithMaximalSum
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two integer numbers N and K 
             * and an array of N elements from the console.
             * Find in the array those K elements that have maximal sum.
            */
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter N elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            int arrayLenght = array.Length;
            int sum = 0;
            Console.WriteLine(new string('-', 50));
            Console.Write("Biggest K numbers in the array are:");
            for (int i = arrayLenght - k; i < arrayLenght; i++)
            {
                Console.Write(array[i] + " ");
                sum += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Maximal sum is: {0}", sum);
            Console.WriteLine(new string('-', 50));
        }
    }
}
