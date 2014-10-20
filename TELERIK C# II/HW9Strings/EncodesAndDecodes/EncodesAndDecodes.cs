using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodesAndDecodes
{
    class EncodesAndDecodes
    {
        /*Write a program that encodes and decodes a string using given
         * encryption key (cipher). The key consists of a sequence of
         * characters. The encoding/decoding is done by performing XOR 
         * (exclusive or) operation over the first letter of the string
         * with the first of the key, the second – with the second, 
         * etc. When the last key character is reached, the next is the first.
            */
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string key1 = Console.ReadLine();

            StringBuilder key = new StringBuilder(key1);
            while (key.Length < str.Length)
            {
                key = key.Append(key);
            }
            string encrypted = EncryptingMethod(str, key);
            string decrypted = EncryptingMethod(encrypted, key);
            Console.WriteLine(encrypted);
            Console.WriteLine(decrypted);
        }

        private static string EncryptingMethod(string str, StringBuilder key)
        {
            char[] strEncrypted = new char[str.Length];                                  
            for (int i = 0; i < str.Length; i++)
            {
                strEncrypted[i] = (char)(str[i] ^ key[i]);
            }
            return new string(strEncrypted);
        }
    }
}
