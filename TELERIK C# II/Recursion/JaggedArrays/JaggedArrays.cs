using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            String[] beers = {"Zagorka", "Ariana",
                              "Shumensko","Astika", "Kamenitza", "Bolqrka",
                              "Amstel"};

            Console.WriteLine("Unsorted: {0}", String.Join(", ", beers));

            Array.Sort(beers);

            Console.WriteLine("Sorted: {0}", String.Join(", ", beers));

            string target = "Shumensko";

            int index = Array.BinarySearch(beers, target);
            Console.WriteLine(index);

            
        }
    }
}