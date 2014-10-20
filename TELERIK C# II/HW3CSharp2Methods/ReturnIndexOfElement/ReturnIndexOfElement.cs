using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsElementInArrayBigger;

namespace ReturnIndexOfElement
{
    class ReturnIndexOfElement
    {
        
        static void Main(string[] args)
        {

            /*Write a method that returns the index of the first element in array that is 
             * bigger than its neighbors, or -1, if there’s no such element.
               Use the method from the previous exercise.
            */

            Console.WriteLine("Enter array lenght");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("Fill the array");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            
            int result = IndexOfBigger(numbers);
            Console.WriteLine(new string('-', 70));
            if (result > 0)
            {
                Console.WriteLine("First number possition that is bigger than its neighbours = {0}", result);
            }
            else
            {
                Console.WriteLine("No such number in the array");
                Console.WriteLine(result);
            }
            Console.WriteLine(new string('-', 70));
        }

        static int IndexOfBigger(List<int> numbers)
        {
            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (IsElementInArrayBigger.IsElementInArrayBigger.IsBigger(i, numbers))
                {
                    return i;
                }
            }
            return -1;
        }
        
        

        
    }
}
