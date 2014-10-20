using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndEnctyptSecond
{
    class EncodeAndEnctyptSecond
    {
        static void Main(string[] args)
        {
            
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();
 
            string resul = Encode(Encrypt(message, cypher) + cypher) + cypher.Length;
            Console.WriteLine(resul);
        }

        private static string Encode(string text)
        {
            StringBuilder result = new StringBuilder();
            char previousSymbol = text[0];
            int counter = 1;
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == previousSymbol)
                {
                    counter++;
                }
                else
                {
                    if (counter == 1)
                    {
                        result.Append(previousSymbol);
                    }
                    else if (counter == 2)
                    {
                        result.Append(new string(previousSymbol, 2));
                    }
                    else
                    {
                        result.Append(counter + previousSymbol.ToString());
                    }
                    counter = 1;
                }
                previousSymbol = text[i];
            }
            if (counter == 1)
            {
                result.Append(previousSymbol);
            }
            else if (counter == 2)
            {
                result.Append(new string(previousSymbol, 2));
            }
            else
            {
                result.Append(counter + previousSymbol.ToString());
            }
            return result.ToString();
        }

        private static string Encrypt(string message, string cypher)
        {
            string result = string.Empty;
           
            if (message.Length >= cypher.Length)
            {
                result = EncryptWhenMassageIsLonger(message, cypher);
            }
            else
            {
               result = EncryptWhenCypherIsLonger(message, cypher);
            }

            return result;
        }

        private static string EncryptWhenCypherIsLonger(string message, string cypher)
        {
            StringBuilder result = new StringBuilder(message);

            int j = 0;

            for (int i = 0; i < cypher.Length; i++)
            {
                char messageSymbol = result[j];
                char cypherSymbol = cypher[i];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);
                result[j] = encryptedSymbol;
                j++;
                if (j == message.Length)
                {
                    j = 0;
                }
            }
            return result.ToString();
        }

        private static string EncryptWhenMassageIsLonger(string message, string cypher)
        {
            StringBuilder result = new StringBuilder();

            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char messageSymbol = message[i];
                char cypherSymbol = cypher[j];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

                result.Append(encryptedSymbol);

                j++;
                if (j == cypher.Length)
                {
                    j = 0;
                }
            }



            return result.ToString();
        }

        private static char EncryptSymbol(char messageSymbol, char cypherSymbol)
        {
            int massageSymbolCOde = messageSymbol - 'A';
            int cyperSymbolCOde = cypherSymbol - 'A';

            int xoredSymbol = massageSymbolCOde ^ cyperSymbolCOde;
            char encrypted = (char)(xoredSymbol + 'A');

            return encrypted;
        }
    }
}
