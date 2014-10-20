using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllSongsWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load("../../../catalogue.xml");

            var songs = xmlDoc.Descendants("Song").Select(s => s.Element("Title").Value);

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
