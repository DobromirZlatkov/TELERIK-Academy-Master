using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


class Numbers
{
    static void Main()
    {

        string text = Console.ReadLine();

        BigInteger result = 0;

        int[] lettersUpper = new int[26];

        int[] lettersLower = new int[6];

        List<decimal> NewResult = new List<decimal>();

        for (int i = 0; i <= 25; i++)  //--->26 symbols from A to Z // A=0; B=1; C=2;
        {
            lettersUpper[i] = 'A' + i;
        }

        for (int i = 0; i <= 5; i++)   // ---->6 symbola from a to f a=0 , f=5
        {
            lettersLower[i] = 'a' + i;
        }

        for (int i = 0; i < text.Length; i++)
        {

            if (text[i] >= 'A' && text[i] <= 'Z')// checking if the symbol is capital letter
            {
                for (int p = 0; p < 26; p++)
                {
                    if (text[i] == (char)lettersUpper[p])
                    {
                        NewResult.Add(p);// adding the value of the letter in list
                        break;
                    }
                }
            }
            else if (char.IsLower(text[i]))// cheking if the letter i small
            {
                for (int p = 0; p <= 5; p++)// checking whic letter is that 
                {
                    for (int q = 0; q < 26; q++)// checking the capital letter because after small one there is always capiatal
                    {
                        if ((int)text[i] == lettersLower[p] && (int)text[i + 1] == lettersUpper[q])
                        {

                            NewResult.Add((p + 1) * 26 + q);// adding the value of small letter+1 to avoid that we start from 0 *26 + the value of capittal letter
                            i++;// to avoid by next check to take the capital letter which is in combination with the small letter
                        }
                    }
                }
            }
        }

        for (int i = 0; i < NewResult.Count; i++)
        {
            result += (BigInteger)NewResult[i] * (BigInteger)(Math.Pow(168, NewResult.Count - i - 1));
        }   //                  so here we have the firts value * 168^ by the lenght of the list -1 to escape range exception

        Console.WriteLine(result);
    }
}