using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TELERIK_DATABASE_XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode catalogue = xmlDoc.CreateElement("Catalogue");

            for (int i = 0; i < 5; i++)
            {
                var currentAlbum = MakeAlbumNode("Hitovete" + i, "Lili ivanova" + i, "1903", "Vasko Keca", 2, 10, xmlDoc);
                catalogue.AppendChild(currentAlbum);
            }
            xmlDoc.AppendChild(catalogue);
            xmlDoc.Save(@"..\..\catalogue.xml");             
        }

        private static XmlNode MakeAlbumNode(string albumNameText, string artistNameText, string yearText, string producerName, decimal priceText, int numberOfSongsInAlbum, XmlDocument xmlDoc)
        {
            XmlNode album = xmlDoc.CreateElement("Album");
            XmlNode albumName = xmlDoc.CreateElement("Name");
            XmlNode artistName = xmlDoc.CreateElement("Artist");
            XmlNode year = xmlDoc.CreateElement("Year");
            XmlNode producer = xmlDoc.CreateElement("Producer");
            XmlNode price = xmlDoc.CreateElement("Price");
            XmlNode songs = xmlDoc.CreateElement("Songs");
            albumName.InnerText = albumNameText;
            artistName.InnerText = artistNameText;
            year.InnerText = yearText;
            producer.InnerText = producerName;
            price.InnerText = priceText.ToString();
            
            for (int i = 0; i < numberOfSongsInAlbum; i++)
            {
                var currentSong = MakeSongNode("Vetrove" + i, 12.5, xmlDoc);
                songs.AppendChild(currentSong);
            }

            album.AppendChild(albumName);
            album.AppendChild(artistName);
            album.AppendChild(year);
            album.AppendChild(producer);
            album.AppendChild(price);
            album.AppendChild(songs);

            return album;

        }

        private static XmlNode MakeSongNode(string titleText, double durationContent,XmlDocument xmlDoc)
        {
            XmlNode song = xmlDoc.CreateElement("Song");
            XmlNode title = xmlDoc.CreateElement("Title");
            XmlNode duration = xmlDoc.CreateElement("Duration");
           
            duration.InnerText = durationContent.ToString();
            title.InnerText = titleText;
            song.AppendChild(title);
            song.AppendChild(duration);

            return song;
        }
    }
}
