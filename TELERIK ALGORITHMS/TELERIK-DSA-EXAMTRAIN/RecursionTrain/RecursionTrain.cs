using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTrain
{
    class RecursionTrain
    {
        static void Main(string[] args)
        {
            Gen01(3, new int[4]);
        }

        static void Gen01(int index, int[] vector)
        {
            if (index == - 1)
            {
                Console.WriteLine(string.Join(", ", vector));
            }
            else
            {
                for (int i = 0; i <= 2; i++)
                {
                    vector[index] = i;
                    Gen01(index - 1, vector);
                }
            }
        }
    }
}
