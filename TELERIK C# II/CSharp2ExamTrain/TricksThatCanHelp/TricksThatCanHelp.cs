using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricksThatCanHelp
{
    class TricksThatCanHelp
    {
        static void Main(string[] args)
        {
            // rechnik
            List<string> words = new List<string>();
            words.Add("gosho");
            words.Add("pesho");

            words.Remove("gosho");//raboti bavno
            words.RemoveAt(0);

            HashSet<int> quickWords = new HashSet<int>();// raboti burzo no nqma indeksator
            quickWords.Add(1);
            quickWords.Add(1);
            quickWords.Add(5); // dobavq samo 1 element nemoje da se povtarqt
            // raboti za unikalni dumi ;]
            quickWords.Add(6);

            quickWords.Remove(5);// raboti burzo

            SortedSet<int> sortedNumbers = new SortedSet<int>();// dobavq samo 1 element nemoje da se povtarqt
            sortedNumbers.Add(5);
            sortedNumbers.Add(1);
            sortedNumbers.Add(8);
            sortedNumbers.Add(4);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
            
            Dictionary<string, int> dict = new Dictionary<string, int>();

            
        }
    }
}
