using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace TRES4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            List<string> sb = new List<string>();
            while (n > 0)
            {
                int reminder = (int)(n % 9);
                n = n / 9;
                switch (reminder)
                {
                    case 0:
                        sb.Add("LON+");
                        break;
                    case 1:
                        sb.Add("VK-");
                        break;
                    case 2:
                        sb.Add("*ACAD");
                        break;
                    case 3:
                        sb.Add("^MIM");
                        break;
                    case 4:
                        sb.Add("ERIK|");
                        break;
                    case 5:
                        sb.Add("SEY&");
                        break;
                    case 6:
                        sb.Add("EMY>>");
                        break;
                    case 7:
                        sb.Add("/TEL");
                        break;
                    case 8:
                        sb.Add("<<DON");
                        break;
                    default:
                        break;
                }
            }
            for (int i = sb.Count - 1; i >= 0 ; i--)
            {
                Console.Write(sb[i]);
            }
        }
    }
}
