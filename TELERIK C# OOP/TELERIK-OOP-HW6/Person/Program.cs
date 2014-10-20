using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person("Peter", 27);
            Person ivan = new Person("Ivan");
            Console.WriteLine(ivan);
            Console.WriteLine();
            Console.WriteLine(peter);
        }
    }
}
