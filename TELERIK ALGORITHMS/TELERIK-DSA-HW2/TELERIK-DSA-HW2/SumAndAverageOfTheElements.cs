using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELERIK_DSA_HW2
{
    class SumAndAverageOfTheElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                string currentLine = Console.ReadLine();
                int currentNumber;
                bool isNumber = int.TryParse(currentLine, out currentNumber);
                if (isNumber)
                {
                    numbers.Add(currentNumber);
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine(CalculateSum(numbers));

            Console.WriteLine(CalculateAverage(numbers)); 

        }

        private static double CalculateAverage(List<int> numbers)
        {
            int numbersCont = numbers.Count();
            int sum = 0;
            for (int i = 0; i < numbersCont; i++)
            {
                sum += numbers[i];
            }
            double result = (double)sum / (double)numbersCont;

            return result;
        }

        private static int CalculateSum(List<int> numbers)
        {
            int numbersCont = numbers.Count();
            int sum = 0;
            for (int i = 0; i < numbersCont; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
