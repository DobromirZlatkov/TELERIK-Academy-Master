using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TwoIsBetterThanOne
    {
        static bool isPolidrome(long number)
        {
            string num = number.ToString();
            for (int i = 0; i < num.Length/2; i++)
            {
                if (num[i] != num[num.Length -i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static int FindluckyNumbers(long lowerBount, long upperBound)
        {
            long max = upperBound;//1000000000000000000;
            int left = 0;
            var numbers = new List<long>{3,5};

            int count = 0;
            while (left < numbers.Count)
	        {
	            int right = numbers.Count;
                for (int i = left; i < right; i++)
			    {
                    if (numbers[i] < max)
                    {
                        numbers.Add((numbers[i] * 10) + 3);
                        numbers.Add((numbers[i] * 10) + 5);
                    }
			    }
                left = right;
	        }

            foreach (var num in numbers)
            {
                if (num >= lowerBount && num <= upperBound && isPolidrome(num))
                {
                    count++;
                }                
            }
            return count;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            long lowerBount = long.Parse(tokens[0]);

            long upperBount = long.Parse(tokens[1]);

            int cont = FindluckyNumbers(lowerBount, upperBount);

            string inputList = Console.ReadLine();
            string[] listTokoen = inputList.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            for (int i = 0; i < listTokoen.Length; i++)
            {
                numbers.Add(int.Parse(listTokoen[i]));
            }
            int p = int.Parse(Console.ReadLine());
            int answerSecndTask = FindAnswerSecondTask(numbers, p);
            Console.WriteLine(cont);
            Console.WriteLine(answerSecndTask);
        }

        private static int FindAnswerSecondTask(List<int> numbers, int percent)
        {
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                int countSmaller = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] >= numbers[j])
                    {
                        countSmaller++;
                    }
                }
                if (countSmaller >= numbers.Count * (percent / 100.0))
                {
                    return numbers[i];
                }
            }
            return numbers[numbers.Count - 1];
        }
    }
}
