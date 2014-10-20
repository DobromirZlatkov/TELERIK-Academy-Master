using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndSUbstringInText
{
    class FIndSUbstringInText
    {
        static void Main(string[] args)
        {
            string tekst = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string substringToFInd = Console.ReadLine();
            Console.WriteLine(FIndSUbstringInTex(tekst, substringToFInd));
        }
        private static int FIndSUbstringInTex(string tekst, string substringToFInd)
        {
            int couter = 0;
            for (int i = 0; i < tekst.Length - 1; i++)
            {
                if (tekst.Substring(i, 2).ToLower() == substringToFInd)
                {
                    couter++;
                }
            }
            return couter;
        }
    }
}
