using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AllSongTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create(@"../../../catalogue.xml");
            using (reader)
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
