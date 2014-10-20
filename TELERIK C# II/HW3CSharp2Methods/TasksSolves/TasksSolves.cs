using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevrseDigitMethod;
namespace TasksSolves
{
    class TasksSolves
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what operation you want to do:");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("To reverse the digits of a number press 1");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("To Calculate the average of a sequence of integers press 2");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("To Solve a linear equation a * x + b = 0 press 3");
            Console.WriteLine(new string('-', 70));
            Console.Write("Enter your choise:");
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 70));

            switch (choise)
            {
                case 1: Console.WriteLine("Enter number.");
                   decimal number = decimal.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Input cannot be negative");                        
                    }
                    else
                    {
                        Console.WriteLine(RevrseDigitMethod.RevrseDigitMethod.ReverseDigits(number));
                    }
                    break;
                case 2: Console.Write("Enter how many numbers you want to enter:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Enter your numbers");                   
                    int sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += int.Parse(Console.ReadLine());
                    }
                    if (n <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        Console.Write("Average sum = ");
                        Console.WriteLine(AverageOfIntegers(sum, n));
                    }                    
                    break;
                case 3: Console.WriteLine("Enter numbers A and B.");
                    decimal a = decimal.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("Invalid input. A should not be 0 ");
                        break;
                    }
                    decimal b = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("x = " + LinearEquation(a,b));
                    break;
                default: Console.WriteLine("Invalid choise");
                    break;
            }

        }

        private static decimal LinearEquation(decimal a, decimal b)
        {
            return -(b) / a;
        }

        private static int AverageOfIntegers(int sum, int n)
        {
            return sum / n;
        }
    }
}
