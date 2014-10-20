using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WithXPath
{
    class WithXPath
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\catalogue.xml");

            XmlNode root = xmlDoc.DocumentElement;

            Dictionary<string, int> artistsSongs = new Dictionary<string, int>();

            foreach (XmlNode  node in root.ChildNodes)
            {
                var artistName = node["Artist"].InnerText;
                if (!artistsSongs.ContainsKey(artistName))
                {
                    artistsSongs[artistName] = 0; ;
                }
                artistsSongs[artistName] += 1;
            }

            foreach (var artistSongs in artistsSongs)
            {
                Console.WriteLine("{0} has {1} albums", artistSongs.Key, artistSongs.Value);
            }
        }
    }
}
