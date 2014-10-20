using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial1_100
{
    class NFactorial1_100
    {
        static void Main(string[] args)
        {
           DateTime start = DateTime.Now;
           Console.WriteLine("Enter N ");
           int n = int.Parse(Console.ReadLine());

           int[] result = FactorialN(n);

           for (int i = result.Length - 1; i >= 0; i--)
           {
               Console.Write(result[i]);
           }
           Console.WriteLine();

           DateTime end = DateTime.Now;
           Console.WriteLine(end - start);
        }

        private static int[] FactorialN(int n)
        {
            int[] helpList = {1};
            for (int i = 1; i <= n; i++)
            {
                List<int> factorialNdigits = new List<int>();

                int add = 0;
                for (int j = 0; j < helpList.Length; j++)
                {
                    factorialNdigits.Add((helpList[j] * i + add) % 10);
                    add = (helpList[j] * i + add) / 10;
                }
                while (add > 0)
                {
                    factorialNdigits.Add(add % 10);
                    add = add / 10;
                }

                helpList = factorialNdigits.ToArray();
                factorialNdigits.Clear();
            }
            return helpList;
        }
    }
}
