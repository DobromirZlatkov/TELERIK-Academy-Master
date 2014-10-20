using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxMethod
{
    class GetMaxMethod
    {
        static void Main(string[] args)
        {
            /*Write a method GetMax() with two parameters that
             * returns the bigger of two integers. Write a
             * program that reads 3 integers from the console
             * and prints the biggest of them using the method
             * GetMax().
            */
            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Biggest is {0}", GetMax(firstNumber, secondNumber));

            Console.WriteLine("Enter third number");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Biggest is {0}", GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
            
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {             
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }       
    }
}
