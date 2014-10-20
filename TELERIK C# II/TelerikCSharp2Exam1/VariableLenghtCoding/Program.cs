using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLenghtCoding
{
    class Program
    {
        private static string DecimalToBinary(int number)
        {
            string result = Convert.ToString(number, 2).PadLeft(8, '0');
            return result;
        }
        private static List<int> LoadMethod()
        {
            string input = Console.ReadLine();
            string[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> encodetText = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                encodetText.Add(int.Parse(array[i]));
            }
            return encodetText;
        }
        private static Dictionary<int, char> LoadDictionaryMethod(int L)
        {
            Dictionary<int, char> codeWords = new Dictionary<int, char>();
            for (int i = 0; i < L; i++)
            {
                string input = Console.ReadLine();
                StringBuilder temp = new StringBuilder();
                for (int j = 1; j < input.Length; j++)
                {
                    temp.Append(input[j]);
                }
                codeWords.Add(int.Parse(temp.ToString()), input[0]);
                temp = temp.Clear();

            }
            return codeWords;
        }

        static void Main(string[] args)
        {
            List<int> encodedText = LoadMethod();

            int L = int.Parse(Console.ReadLine());

            Dictionary<int, char> codeWords = LoadDictionaryMethod(L);
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encodedText.Count; i++)
            {
                sb.Append(DecimalToBinary(encodedText[i]));
            }
           
            StringBuilder papaz = new StringBuilder();

            int counter = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                while (true)
                {
                    if (sb[i] == '1')
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    i++;
                }
                if (counter != 0)
                {
                    papaz.Append(codeWords[counter]); 
                }
               
                
                counter = 0;
            }
            Console.WriteLine(papaz);            
        }                
    }
}
