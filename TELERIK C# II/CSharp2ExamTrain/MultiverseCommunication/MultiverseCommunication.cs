using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class MultiverseCommunication
    {
        static void Main(string[] args)
        {
            string massage = Console.ReadLine();

            Dictionary<string, string> encryptTable = LoadTableinDictionary();

            long result = ConvertToDecimal(massage, encryptTable);
            Console.WriteLine(result);
        }

        private static long ConvertToDecimal(string massage, Dictionary<string, string> encryptTable)
        {

            List<string> numbers = new List<string>();

            long result = 0;
            for (int i = 0; i < massage.Length; i+=3)
            {
                string digit = massage.Substring(i, 3);
                if (encryptTable.ContainsKey(digit))
                {
                    numbers.Add(encryptTable[digit]);
                }                
            }
            result = ConvertToDec(result, numbers);
            
            return result;
        }

        private static long ConvertToDec(long result, List<string> numbers)
        {
            long decimalNumber = 0;
            int j = 0;
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                decimalNumber += long.Parse(numbers[i]) * ((long)Math.Pow(13, j));
                j++;
            }

            return decimalNumber;
        }

        private static Dictionary<string, string> LoadTableinDictionary()
        {
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("CHU", "0");
            table.Add("TEL", "1");
            table.Add("OFT", "2");
            table.Add("IVA", "3");
            table.Add("EMY", "4");
            table.Add("VNB", "5");
            table.Add("POQ", "6");
            table.Add("ERI", "7");
            table.Add("CAD", "8");
            table.Add("K-A", "9");
            table.Add("IIA", "10");
            table.Add("YLO", "11");
            table.Add("PLA", "12");
            return table;
        }
    }
}
