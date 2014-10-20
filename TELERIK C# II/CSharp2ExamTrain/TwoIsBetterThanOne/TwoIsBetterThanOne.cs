using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIsBetterThanOne
{
    class TwoIsBetterThanOne
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            long lowerBount = long.Parse(tokens[0]);

            long upperBount = long.Parse(tokens[1]);

            int cont = FindluckyNumbers(lowerBount, upperBount);

            string secondTaskInput = Console.ReadLine();


            int P = int.Parse(Console.ReadLine());
            string[] secondTask = secondTaskInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] secondTaskNumbers = new int[secondTask.Length];
            for (int i = 0; i < secondTask.Length; i++)
            {
                secondTaskNumbers[i] = int.Parse(secondTask[i]);
            }



            
            Console.WriteLine(cont);
            int numberOfPersantage = FindPercents(secondTaskNumbers, P);
            Console.WriteLine(numberOfPersantage);


        }

        private static int FindPercents(int[] secondTaskNumbers, int p)
        {
            Array.Sort(secondTaskNumbers);
            int result = 0;
            //int a = 39;
            //double percent = (double)a / 100;
            //Console.WriteLine(percent);
           
            //int papaz = 9;
            //double result = (double)papaz * percent;
            //Console.WriteLine(result);
            double percent = (double)p / 100;

            double resulttt = (double)secondTaskNumbers.Length * percent;
           

            int papaz = (int)resulttt;
            
            if (resulttt > papaz)
            {
                result = secondTaskNumbers[(int)resulttt]; 
            }          
            else
            {
                result = secondTaskNumbers[(int)resulttt - 1];               
            }

            return result;
        }

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
        }
    }


