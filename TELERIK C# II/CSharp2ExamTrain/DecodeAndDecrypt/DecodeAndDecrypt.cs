using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class DecodeAndDecrypt
    {
        static void Main(string[] args)
        {
            string massage = Console.ReadLine();
            string cypher = Console.ReadLine();

            string cypherText;
            Encrypt(massage, cypher);
        }

        private static void Encrypt(string massage, string cypher)
        {
            throw new NotImplementedException();
        }
    }
}
