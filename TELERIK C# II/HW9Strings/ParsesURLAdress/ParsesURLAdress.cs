using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ParsesURLAdress
{
    class ParsesURLAdress
    {
        /*Write a program that parses an URL address given in the format:

		and extracts from it the [protocol], [server] and [resource] elements. 
         * For example from the URL http://www.devbg.org/forum/index.php the 
         * following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
        */
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";
            DefragmentURL(url);

        }

        private static void DefragmentURL(string url)
        {
            
            //var fragmentation = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
            int protocolEnd = url.IndexOf(':');
            string protocol = url.Substring(0, protocolEnd);
            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            url = url.Replace(url.Substring(0, protocolEnd + 3), "");

            int serverEnd = url.IndexOf('/');
            string server = url.Substring(0, serverEnd);
            Console.WriteLine("[server] = \"{0}\"", server);
            url = url.Replace(url.Substring(0, serverEnd), "");

            Console.WriteLine("[resource] = \"{0}\"", url);
        }
    }
}
