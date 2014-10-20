using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
namespace ExtractDatesWithFormat
{
    class ExtractDatesWithFormat
    {
        /*Write a program that extracts from a given text all dates that match 
         * the format DD.MM.YYYY. Display them in the standard date format 
         * for Canada.
        */
        static void Main(string[] args)
        {
            string format = "dd.MM.yyyy";
            string text ="21.01.2012, 2.12.13, 31.12.2014, 1 януари 2012, 02.03.2000,22/12/2001";
            string[] words = text.Split(' ', ',','/');
            string regular = @"\b\d{2}.\d{2}.\d{4}\b";
            for (int i = 0; i < words.Length; i++)
            {
                bool isDateCorrect = Regex.IsMatch(words[i], regular);
                if (isDateCorrect)
                {                    
                    DateTime date = DateTime.ParseExact(words[i], format, CultureInfo.InvariantCulture);
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
                }
            }         
        }
    }
}
