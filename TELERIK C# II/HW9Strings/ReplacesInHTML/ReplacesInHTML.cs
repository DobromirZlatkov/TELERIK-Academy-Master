using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacesInHTML
{
    class ReplacesInHTML
    {
        static void Main(string[] args)
        {
            string url = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            for (int i = 0; i < url.Length; i++)
            {
               url = url.Replace("<a href=\"", "[URL=");
               url = url.Replace("\">", "]");
               url = url.Replace("</a>", "[/URL]");
            }
            Console.WriteLine(url);
        }
    }
}
