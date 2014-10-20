using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_SoftUNI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine());
            string bitsAsString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                byte number = byte.Parse(Console.ReadLine());
                string numberAsString = Convert.ToString(number, 2).PadLeft(8, '0');
                bitsAsString += numberAsString;
            }
            char[] bitsAsChars = bitsAsString.ToCharArray();

            

            for (int step = 1; step < bitsAsChars.Length;step += steps)
            {
                bitsAsChars[step] = '1';
            }
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bitsAsChars.Length; i += 8)
            {
                for (int j = i; j < i + 8; j++)
                {
                    sb.Append(bitsAsChars[j].ToString());
                }       
                Console.WriteLine(Convert.ToInt32(sb.ToString(), 2).ToString());
                sb.Clear();
                
            }
        }
    }
}
