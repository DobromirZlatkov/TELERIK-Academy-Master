using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_SoftUNI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstAndLastLine = " " + new string('*', ((n * 2) - 2)) + new string(' ', (n + 1)) + new string('*', ((n * 2) - 2)) + " ";
            Console.WriteLine(firstAndLastLine);

            int innerAsterix = (n * 2) - 2;
            int emptySpace = n - 1;
            char currentSymbol = ' ';
            for (int i = 0; i < n-2; i++)
            {
                if (i == (n - 2) / 2)
                {
                    currentSymbol = '-'; 
                }
                else
                {
                    currentSymbol = ' ';
                }
                Console.Write("*");
                Console.Write( new string('/', innerAsterix));
                Console.Write("*");
                Console.Write(new string(currentSymbol, emptySpace));
                Console.Write("*");
                Console.Write(new string('/', innerAsterix));
                Console.Write("*");
                Console.WriteLine();
            }



            Console.WriteLine(firstAndLastLine);
        }
    }
}
