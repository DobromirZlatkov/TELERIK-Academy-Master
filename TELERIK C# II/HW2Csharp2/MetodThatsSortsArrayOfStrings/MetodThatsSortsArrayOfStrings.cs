using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodThatsSortsArrayOfStrings
{
    class MetodThatsSortsArrayOfStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array Length");
            int n = int.Parse(Console.ReadLine());

            string[] stringArray = new string[n];

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            Console.WriteLine();


            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Non sorted array");       
            PrintArray(stringArray);
            Console.WriteLine();

            
            StringLenghtSort(stringArray, stringArray.Length);


            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Sorted array");      
            PrintArray(stringArray);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
        }

        private static void PrintArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write("\"{0}\"; ", stringArray[i]);
            }
        }

        private static void StringLenghtSort(string[] stringArray, int stringArrayLenght)
        {
            for (int i = 0; i < stringArrayLenght; i++)
            {
                int pivot = i;

                for (int j = 0; j < stringArrayLenght; j++)
                {
                    if ((stringArray[j].Length < stringArray[pivot].Length && j > pivot)
                        || (stringArray[j].Length > stringArray[pivot].Length && j < pivot))
                    {
                        string temp = "";
                        temp = stringArray[j];
                        stringArray[j] = stringArray[pivot];
                        stringArray[pivot] = temp;
                        pivot = i;

                    }
                }
            }
        }
    }
}
