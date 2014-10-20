using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000000;
            DateTime start = DateTime.Now;
            for (int i = 0; i < n; i++)
            {
                
            }
            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);

            start = DateTime.Now;
            for (int i = 0; i < n; i++)
            {
                EmptyMethod();
            }
            end = DateTime.Now;
            Console.WriteLine(end - start);
        }

        static void EmptyMethod()
        { 
            
        }
    }
}
