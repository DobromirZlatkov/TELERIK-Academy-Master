using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace DuranKulakNumbersSecondTtry
{
    class DuranKulakNumbersSecondTtry
    {
        static void Main(string[] args)
        {
            string durankulakNumber = Console.ReadLine();

            List<string> durankulakDigits = LoadMethod();            

            List<string> separateDurankulakNumber = SeparateInput(durankulakNumber);
                 
            BigInteger result = DuranKulakToDecimal(separateDurankulakNumber, durankulakDigits);

            Console.WriteLine(result);


           
        }

        private static BigInteger DuranKulakToDecimal(List<string> separateDurankulakNumber, List<string> durankulakDigits)
        {

            BigInteger result = 0;
            int power = 0;
            for (int i = separateDurankulakNumber.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < durankulakDigits.Count; j++)
                {
                    if (separateDurankulakNumber[i] == durankulakDigits[j])
                    {
                        result += j * (BigInteger)Math.Pow(168, power);
                        power++;
                    }
                }
            }
            return result;
        }

        private static List<string> SeparateInput(string durankulakNumber)
        {
            List<string> separateInput = new List<string>();
            for (int i = 0; i < durankulakNumber.Length ; i++)
            {
                if (durankulakNumber[i] >= 'a' && durankulakNumber[i] <= 'f')
                {
                    separateInput.Add(durankulakNumber[i].ToString() + durankulakNumber[i + 1].ToString());
                    i++;
                }
                else
                {
                    separateInput.Add(durankulakNumber[i].ToString());
                }
            }
            return separateInput;
        }

        private static List<string> LoadMethod()
        {
            List<string> durankulakDigits = new List<string>();

            for (char i = 'A'; i <= 'Z'; i++)
            {
                durankulakDigits.Add(i.ToString());
            }
            for (char i = 'a'; i <= 'f'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    durankulakDigits.Add(i.ToString() + j.ToString());
                }
            }
            return durankulakDigits;
        }
               
    }
}
