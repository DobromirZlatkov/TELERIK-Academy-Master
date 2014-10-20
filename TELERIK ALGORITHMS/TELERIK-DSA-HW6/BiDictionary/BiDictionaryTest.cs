using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDictionary
{
    class BiDictionaryTest
    {
        static void Main(string[] args)
        {
            BiDictionary<int, int, string> bidict = new BiDictionary<int, int, string>();

            for (int i = 0; i < 100000; i++)
            {
                int firstKey = i ^ 12;
                int secondKey = i ^ 22;
                string value = "value"+i.ToString();
                bidict.Add(firstKey, secondKey, value);
            }



            var ValuesByFirstKey = bidict.FindByFistKey(100 ^ 12);
            foreach (var value in ValuesByFirstKey)
            {
                 Console.WriteLine("By first key : "+ value);
            }

            Console.WriteLine("----------------------------");

            var valuesBySecondKey = bidict.FindBySecondKey(100 ^ 22);
            foreach (var value in valuesBySecondKey)
            {
                Console.WriteLine("By second key : " + value);
            }

            Console.WriteLine("----------------------------");

            var valuesByBothKeys = bidict.FindByBothKeys(100 ^ 12, 100 ^ 22);
            foreach (var value in valuesByBothKeys)
            {
                 Console.WriteLine("By both keys : " + value);
            }


        }
    }
}
