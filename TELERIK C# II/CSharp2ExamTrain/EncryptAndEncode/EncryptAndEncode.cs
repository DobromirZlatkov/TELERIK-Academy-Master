using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptAndEncode
{
    class EncryptAndEncode
    {
        static void Main(string[] args)
        {
            string massage = Console.ReadLine();
            string crypter = Console.ReadLine();
            CryptMassage(massage, crypter);


            string toEncide = CryptMassage(massage, crypter) + crypter;

            string papaz = Encode(toEncide);
            string result = papaz + crypter.Length;
            Console.WriteLine(result);
        }

        private static string Encode(string toEncode)
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            char current = toEncode[0];
            for (int i = 1; i < toEncode.Length; i++)
            {
                if (current == toEncode[i])
                {
                    count++;
                }
                else
                {
                    if (count == 1)
                    {
                        sb.AppendFormat("{0}", current);
                    }
                    else if (count == 2)
                    {
                        sb.AppendFormat("{0}{1}", current, current);
                    }
                    else
                    {
                        sb.AppendFormat("{0}{1}", count, current);
                    }                    
                    count = 1;
                    current = toEncode[i];
                }
            }

            if (count == 1)
            {
                sb.AppendFormat("{0}", current);
            }
            else if (count == 2)
            {
                sb.AppendFormat("{0}{1}", current, current);
            }
            else
            {
                sb.AppendFormat("{0}{1}", count, current);
            }

            return sb.ToString();
        }

        private static string CryptMassage(string massage, string crypter)
        {
            //var papaz = 0 ^ 15;
            //papaz = papaz + 'A';
            //char laino = (char)papaz;
            //Console.WriteLine(papaz);
            //Console.WriteLine(laino);
            //return "a";

            int lengt = Math.Max(massage.Length, crypter.Length);            
            var result = new StringBuilder();
            for (int i = 0, mID = 0, cID = 0; i < lengt; i++)
            {
                int massageCode;
                int encryptCode = crypter[cID] - 'A';
                int lenght1 = massage.Length;
                int lenght2 = crypter.Length;
                if (lenght1 >= lenght2)
                {
                    massageCode = massage[mID] - 'A';
                    result.Append((char)((massageCode ^ encryptCode) + 'A'));
                    if (crypter.Length - 1 == cID)
                    {
                        cID = 0;
                        mID++;
                    }
                    else
                    {
                        cID++;
                        mID++;
                    }
                }
                else
                {         
                    if (massage.Length > result.Length)
                    {                                              
                        massageCode = massage[mID] - 'A';  
                        result.Append((char)((massageCode ^ encryptCode) + 'A'));
                        cID++;
                        mID++;                       
                        if (massage.Length  == result.Length)
                        {                           
                            mID = 0;                         
                        }
                    }                    
                    else
                    {                       
                        massageCode = result[mID] - 'A';
                        result[mID] = ((char)((massageCode ^ encryptCode) + 'A'));
                        mID++;
                        cID++;
                        if (massage.Length == mID)
                        {
                            mID = 0;
                        }
                    }                   
                }         
            }

            return result.ToString();
        }
    }
}
