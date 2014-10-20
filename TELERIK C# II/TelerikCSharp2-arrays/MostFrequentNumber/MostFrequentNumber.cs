using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            // load array
            Console.WriteLine("Enter array members:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            
            int temp = 0;
            int number = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int equalNumbers = 1;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (numbers[i] == numbers[j])
                    {
                        equalNumbers++;
                    }
                    if (equalNumbers > temp)
                    {
                        temp = equalNumbers;
                        number = numbers[i];
                    }
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.Write("Most frequent number is: {0} (", number);
            Console.WriteLine(temp + " times)");
            Console.WriteLine(new string('-', 50));

        }
    }
}
