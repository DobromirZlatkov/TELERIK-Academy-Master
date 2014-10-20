using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreGreen
{
    class WeAreGreen
    {
        static void Main(string[] args)
        {
            string papaz = Console.ReadLine();
            char[] laino = papaz.ToCharArray();
            int[] letters = new int[papaz.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (int)laino[i];
            }
            Array.Sort(letters);
            isValid(letters);
            int counter = 0;
            if (isValid(letters))
            {
               counter++;
            }
            while (NextPermutation(letters))
            {
                if (isValid(letters))
                {
                   counter++; 
                }
                
            }
            Console.WriteLine(counter);
        }

        static bool isValid(int[] letters)
        {
            int previous = letters[0];

            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i] == previous)
                {
                    return false;
                }
                previous = letters[i];
            }
            return true;
        }
        
        private static bool NextPermutation(int[] numList)
        {
                   
            var largestIndex = -1;
            for (var i = numList.Length - 2; i >= 0; i--)
            {
                if (numList[i] < numList[i + 1])
                {
                    largestIndex = i;
                    break;
                }
            }

            if (largestIndex < 0) return false;

            var largestIndex2 = -1;
            for (var i = numList.Length - 1; i >= 0; i--)
            {
                if (numList[largestIndex] < numList[i])
                {
                    largestIndex2 = i;
                    break;
                }
            }

            var tmp = numList[largestIndex];
            numList[largestIndex] = numList[largestIndex2];
            numList[largestIndex2] = tmp;

            for (int i = largestIndex + 1, j = numList.Length - 1; i < j; i++, j--)
            {
                tmp = numList[i];
                numList[i] = numList[j];
                numList[j] = tmp;
            }

            return true;
        }
    }
}
