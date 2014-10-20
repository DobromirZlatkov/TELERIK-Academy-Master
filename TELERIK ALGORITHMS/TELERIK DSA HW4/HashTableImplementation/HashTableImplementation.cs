using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    class HashTableImplementation
    {
        static void Main(string[] args)
        {
            HashTable<string, int> myhash = new HashTable<string, int>();

            myhash.Add("Gosho", 1);
            myhash.Add("Desi", 2);
            myhash.Add("Pesho", 3);
            myhash.Add("Roko", 4);
            myhash.Add("Boko", 5);
            myhash.Print();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Do contains values Gosho, Gosho2:{0}, {1}", myhash.ContainsKey("Gosho"), myhash.ContainsKey("Gosho2"));
            Console.WriteLine("----------------------------");
            Console.WriteLine("Select by myhash[\"Boko\"] = {0}", myhash["Boko"]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Set by myhash[\"Boko\"] = {0}", 100);
            Console.WriteLine("----------------------------");
            myhash["Boko"] = 100;
            myhash.Print();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Select by myhash[\"Boko\"] = " + myhash["Boko"]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Delete Boko");
            myhash.Delete("Boko");
            Console.WriteLine("----------------------------");
            foreach (var item in myhash)
            {
                Console.WriteLine(item.Key + "-->" + item.Value);
            }
        }

    }
}
