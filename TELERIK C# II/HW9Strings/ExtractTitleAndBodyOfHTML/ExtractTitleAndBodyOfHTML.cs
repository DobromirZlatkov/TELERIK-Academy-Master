using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace ExtractTitleAndBodyOfHTML
{
    class ExtractTitleAndBodyOfHTML
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("htmlFile.txt");
            string text = string.Empty;
            using (reader)
            {
                text = reader.ReadToEnd();   
            }
            Console.WriteLine(GetTextWithoutHtml(text));
            Console.WriteLine(GetTextWithoutHtmlSecond(text));
        }

        private static string GetTextWithoutHtmlSecond(string text)
        {
            int openTag = text.IndexOf('<');
            int closeTag = text.IndexOf('>');
            while (openTag >= 0)
            {
                text = text.Remove(openTag, closeTag - openTag + 1);
                openTag = text.IndexOf('<');
                closeTag = text.IndexOf('>');
            }
            return text;
        }
        public static string GetTextWithoutHtml(string HTMLText)
        {
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            return reg.Replace(HTMLText, "");
        }
    }
}
