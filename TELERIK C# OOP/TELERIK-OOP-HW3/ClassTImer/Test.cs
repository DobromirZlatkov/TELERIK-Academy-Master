using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ClassTImer
{
    class Test
    {
        static void Main(string[] args)
        {
            Timer first = new Timer(2000, FirstMethod);
            Timer second = new Timer(1000, SecondMethod);
            
        }

        public static void FirstMethod()
        {
            Console.WriteLine("First method");
        }
        public static void SecondMethod()
        {
            Console.WriteLine("Second method");
        }
    }
}
