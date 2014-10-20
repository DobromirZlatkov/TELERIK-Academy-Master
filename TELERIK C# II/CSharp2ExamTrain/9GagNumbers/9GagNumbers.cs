using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _9GagNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

          //  string[] digits = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
            string input = Console.ReadLine();
            List<int> digitsInNumber = new List<int>();
            StringBuilder sb = new StringBuilder();

            

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);

                switch (sb.ToString())
                {
                    case "-!":
                        digitsInNumber.Add(0);
                        sb.Clear();
                        break;
                    case "**":
                        digitsInNumber.Add(1);
                        sb.Clear();
                        break;
                    case "!!!":
                        digitsInNumber.Add(2);
                        sb.Clear();
                        break;
                    case "&&":
                        digitsInNumber.Add(3);
                        sb.Clear();
                        break;
                    case "&-":
                        digitsInNumber.Add(4);
                        sb.Clear();
                        break;
                    case "!-":
                        digitsInNumber.Add(5);
                        sb.Clear();
                        break;
                    case "*!!!":
                        digitsInNumber.Add(6);
                        sb.Clear();
                        break;
                    case "&*!":
                        digitsInNumber.Add(7);
                        sb.Clear();
                        break;
                    case "!!**!-":
                        digitsInNumber.Add(8);
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
                    multiplayer *= 9;
                }
                result += digitsInNumber[i] * multiplayer;
                power++;
            }


            return result;
        }
    }
}

