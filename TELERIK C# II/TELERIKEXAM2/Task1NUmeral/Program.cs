using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task1NUmeral
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<int> digitsInNumber = new List<int>();
            StringBuilder sb = new StringBuilder();

            

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);

                switch (sb.ToString())
                {
                    case "f":
                        digitsInNumber.Add(0);
                        sb.Clear();
                        break;
                    case "bIN":
                        digitsInNumber.Add(1);
                        sb.Clear();
                        break;
                    case "oBJEC":
                        digitsInNumber.Add(2);
                        sb.Clear();
                        break;
                    case "mNTRAVL":
                        digitsInNumber.Add(3);
                        sb.Clear();
                        break;
                    case "lPVKNQ":
                        digitsInNumber.Add(4);
                        sb.Clear();
                        break;
                    case "pNWE":
                        digitsInNumber.Add(5);
                        sb.Clear();
                        break;
                    case "hT":
                        digitsInNumber.Add(6);
                        sb.Clear();
                        break;                   
                    default:
                        break;
                }                
            }
            BigInteger result = ToDecimal(digitsInNumber);
            Console.WriteLine(result);
        }

        private static BigInteger ToDecimal(List<int> digitsInNumber)
        {
            BigInteger result = 0;
            int power = 0;
            
            for (int i = digitsInNumber.Count - 1; i >= 0; i--)
            {
                BigInteger multiplayer = 1;
                for (int j = 0; j < power; j++)
                {
                    multiplayer *= 7;
                }
                result += digitsInNumber[i] * multiplayer;
                power++;
            }
            return result;
        }
        
    }
}
