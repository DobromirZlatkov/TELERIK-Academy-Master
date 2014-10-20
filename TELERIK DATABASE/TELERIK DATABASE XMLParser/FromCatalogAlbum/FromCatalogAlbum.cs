using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FromCatalogAlbum
{
    class FromCatalogAlbum
    {
        static void Main(string[] args)
        {
            List<string> autors = new List<string>();
            List<string> albums = new List<string>();

            using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Artist")
                    {
                        autors.Add(reader.ReadElementString());
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Name")
                    {
                         albums.Add(reader.ReadElementString());
                    }
                }
            }

            using (XmlTextWriter textwriter = new XmlTextWriter("../../albums.xml",Encoding.GetEncoding("UTF-8")))
            {
                textwriter.Formatting = Formatting.Indented;
                textwriter.IndentChar = '\t';

                textwriter.WriteStartDocument();
                textwriter.WriteStartElement("Albums");
                for (int i = 0; i < albums.Count; i++)
                {
                    textwriter.WriteStartElement("Album");
                    textwriter.WriteElementString("Name", albums[i]);
                    textwriter.WriteElementString("Author", autors[i]);
                    textwriter.WriteEndElement();
                }

                textwriter.WriteEndElement();
            }
        }
    }
}
