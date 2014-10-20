using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenesAlgorythm
{
    class SieveOfEratosthenesAlgorythm
    {
        static void Main(string[] args)
        {
            /*Write a program that finds all prime numbers in the range [1...10 000 000].
             * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
             * http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
            */
            Console.WriteLine("Enter number from 0 to 10 000 000 to find all prime numbers in that range");
            int n = int.Parse(Console.ReadLine());
            bool[] numbers = new bool[n];
            double lenght = Math.Sqrt(numbers.Length);

            for (int i = 2; i < lenght; i++)
            {
                if (numbers[i] == false)
                {
                    for (int j = i * i; j < numbers.Length; j += i)
                    {
                        numbers[j] = true;
                    } 
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("All prime numbers in range 0 - {0}", n);
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == false)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }
    }
}
