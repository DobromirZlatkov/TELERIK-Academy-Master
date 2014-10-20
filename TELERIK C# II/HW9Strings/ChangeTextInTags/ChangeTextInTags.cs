using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTextInTags
{
    class ChangeTextInTags
    {
        static void Main(string[] args)
        {
            string str = "We are in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Console.WriteLine( ToUpperInTags(str));            
        }

        private static string ToUpperInTags(string str)
        {
            string openTag = "<upcase>";
            string closeTag = "</upcase>";

            while (str.IndexOf(openTag) != -1)
            {
                int startPos = str.IndexOf(openTag);
                int endPos = str.IndexOf(closeTag);
               
                string temp = str.Substring(startPos + openTag.Length, endPos - startPos - openTag.Length);
                str = str.Replace(openTag + temp + closeTag, temp.ToUpper());
            }
            return str;
        }
    }
}
