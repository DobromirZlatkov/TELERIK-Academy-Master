using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvoichniParoli
{
    class DvoichniParoli
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    counter++;
                }
            }
            long result = 1;
            for (int i = 0; i < counter; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);

        }
    }
}
