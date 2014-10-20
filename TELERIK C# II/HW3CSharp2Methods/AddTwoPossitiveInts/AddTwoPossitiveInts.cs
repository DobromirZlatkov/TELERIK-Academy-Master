using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoPossitiveInts
{
    class AddTwoPossitiveInts
    {
        static void Main(string[] args)
        {
            /*Write a method that adds two positive integer
             * numbers represented as arrays of digits 
             * (each array element arr[i] contains a digit;
             * the last digit is kept in arr[0]). Each of the
             * numbers that will be added could have up to 
             * 10 000 digits.
            */
            Console.WriteLine("Enter firstNumber");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter secondNumber");
            string secondNumber = Console.ReadLine();
                               
            List<int> addedNumbers = new List<int>();

            AddNumberArrays(addedNumbers, firstNumber, secondNumber);

            Print(addedNumbers);
        }

        private static void AddNumberArrays(List<int> addedNumbers, string firstNumber, string secondNumber)
        {
            int[] firstNumberChars = new int[firstNumber.Length];
            int[] secondNumberChars = new int[secondNumber.Length];

            for (int i = 0; i < firstNumber.Length; i++)
            {
                firstNumberChars[i] = int.Parse(firstNumber[i].ToString());
            }
            for (int i = 0; i < secondNumber.Length; i++)
            {
                secondNumberChars[i] = int.Parse(secondNumber[i].ToString());
            }

            Array.Reverse(firstNumberChars);
            Array.Reverse(secondNumberChars);
          
            int finalArrayLenth = Math.Min(firstNumberChars.Length, secondNumberChars.Length);

            int add = 0;            
            for (int i = 0; i < finalArrayLenth; i++)
            {
                addedNumbers.Add((firstNumberChars[i] + secondNumberChars[i] + add) % 10);
                add = ((firstNumberChars[i] + secondNumberChars[i] + add) / 10) % 10;
            }
            if (firstNumberChars.Length > secondNumberChars.Length)
            {
                for (int i = secondNumberChars.Length; i < firstNumberChars.Length; i++)
                {
                    addedNumbers.Add((firstNumberChars[i] + add) % 10);
                    add = ((firstNumberChars[i] + add) / 10) % 10;
                }
            }
            if (firstNumberChars.Length < secondNumberChars.Length)
            {
                for (int i = firstNumberChars.Length; i < secondNumberChars.Length; i++)
                {
                    addedNumbers.Add((secondNumberChars[i] + add) % 10);

                    add = ((secondNumberChars[i] + add) / 10) % 10;
                }
            }
            if (add > 0)
            {
                addedNumbers.Add(add);
            }
        }




        private static void Print(List<int> addedNumbers)
        {
            Console.WriteLine(new string('-', 70));
            for (int i = addedNumbers.Count - 1; i >= 0; i--)
            {
                Console.Write(addedNumbers[i]);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 70));
        }


    }
}
