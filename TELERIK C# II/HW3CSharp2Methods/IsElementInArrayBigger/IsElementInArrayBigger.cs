using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsElementInArrayBigger
{
    public class IsElementInArrayBigger
    {
        static void Main(string[] args)
        {
            /*Write a method that checks if the element 
             * at given position in given array of integers 
             * is bigger than its two neighbors 
             * (when such exist).
            */

            Console.WriteLine("Enter lenght if the array");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the array");
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Enter number possition to check if is bigger than its neighbours");
            int possition = int.Parse(Console.ReadLine());


            
            Console.WriteLine(new string('-',70));
            if (possition < 1 || possition > numbers.Count - 1)
            {
                Console.WriteLine("Number {0} at possition {1} dont have two neighbours");
                return;
            }

            Console.WriteLine("Number {0} is bigger than its neighbours - {1}",numbers[possition], IsBigger(possition, numbers));

            Console.WriteLine(new string('-', 70));
            
        }

        public static bool IsBigger(int possition, List<int> numbers)
        {
            
            if (numbers[possition] > numbers[possition-1] && numbers[possition] > numbers[possition + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
