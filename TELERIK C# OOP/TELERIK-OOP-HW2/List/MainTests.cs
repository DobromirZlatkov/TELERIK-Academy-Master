using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class MainTests
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>();
            List<int> aa = new List<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            Console.WriteLine(test.ElementAt(2));
            Console.WriteLine(test.ElementByValue(4));
            Console.WriteLine(new string('-', 50));
            test.InsertAt(1, 100);

            Console.WriteLine(test.ToString());

            Console.WriteLine(new string('-', 50));
            test.RemoveAt(2);
            Console.WriteLine(test.ToString());
            
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(test.Max());
            Console.WriteLine(test.Min());
            Console.WriteLine(new string('-', 50));
            test.Clear();
            Console.WriteLine(test.ToString());


        }

    }
}
