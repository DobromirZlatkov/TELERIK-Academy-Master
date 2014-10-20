using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N length of the array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the array");
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //sort the array

            Array.Sort(numbers);

            // byary search
            while (true)
            {

                int target = Array.BinarySearch(numbers, k);
             
                if (k > numbers[numbers.Length - 1])
                {
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Closest <= K = {0}", numbers[numbers.Length - 1]);
                    Console.WriteLine(new string('-', 50));
                    break;
                }
                else if (target < 0)
                {
                    k--;
                }
                else
                {
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Closest <= K = {0}", numbers[target]);
                    Console.WriteLine(new string('-', 50));
                    break;
                }
            }                     
        }
    }
}
