using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLIstImplementation
{
    class program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> numbers = new MyLinkedList<int>();

            numbers.AddLast(10);
            numbers.AddLast(11);
            numbers.AddFirst(2);

            numbers.RemoveItem(10);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(numbers.Count());
        }
    }
}
