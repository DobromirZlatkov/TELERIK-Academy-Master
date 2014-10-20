using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SoftUNI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long evenSum = 0;
            long oddSum = 0;
            long diff = 0;
           
            for (int i = 0; i < n * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum=" + oddSum);
            }
            else
            {
                Console.WriteLine("No, diff=" + Math.Abs(oddSum - evenSum));
            }
        }
    }
}
