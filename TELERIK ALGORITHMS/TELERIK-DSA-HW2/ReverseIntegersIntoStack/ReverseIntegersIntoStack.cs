using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIntegersIntoStack
{
    class ReverseIntegersIntoStack
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Push(number);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
