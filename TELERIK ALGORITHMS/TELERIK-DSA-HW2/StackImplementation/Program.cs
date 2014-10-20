using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> numbers = new MyStack<int>();
            for (int i = 0; i <= 10; i++)
            {
                numbers.Push(i);
            }

            int lastNum = numbers.Pop();
            Console.WriteLine(lastNum);
            Console.WriteLine(numbers.Contains(2));
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
