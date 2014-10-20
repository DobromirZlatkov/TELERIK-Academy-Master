using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the maximal 
                increasing sequence in an array. Example: 
            {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

            Console.WriteLine("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter numbers to fill the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int increasingSequeceCount = 1;
            int temp = 0;
            int endSequence = 0;           
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == (array[i+1]))
                {
                    increasingSequeceCount++;
                    
                }
                else
                {
                    increasingSequeceCount = 1;
                }
                // if there is larger  sequence will be added to temp.
                if (increasingSequeceCount > temp)
                {
                    temp = increasingSequeceCount;
                    endSequence = i;
                }
               
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Maximal inclreasing sequence has :{0} menbers", temp);
            Console.Write("Maximal increasing sequence is:");
            for (int i = endSequence - (temp - 2); i <= endSequence + 1; i++)
            {              
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
          
        }
    }
}
