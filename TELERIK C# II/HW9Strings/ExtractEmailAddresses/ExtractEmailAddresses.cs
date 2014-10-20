using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ExtractEmailAddresses
{
    class ExtractEmailAddresses
    {
        /*Write a program for extracting all email addresses from given text. 
         * All substrings that match the format <identifier>@<host>…<domain> 
         * should be recognized as emails.
        */
        static void Main(string[] args)
        {
            string text = "Please giv me your e mail address again. papaz@abv.bg is not a valid one.Mine is roco@gmail.com";
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                bool isEmail  = Regex.IsMatch(words[i], @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}");
                if (isEmail)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
