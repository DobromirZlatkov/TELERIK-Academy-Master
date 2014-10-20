using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DeleteElementsWithDom
{
    class DeleteElementsWithDom
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\catalogue.xml");
            XmlNode root = xmlDoc.DocumentElement;
            List<XmlNode> albumsForDeleting = new List<XmlNode>();
            foreach (XmlNode node in root.ChildNodes)
            {
                int price = int.Parse(node["Price"].InnerText);
                if (price > 20)
                {
                    albumsForDeleting.Add(node);
                }
            }


            foreach (var nodeToDelete in albumsForDeleting)
            {
                xmlDoc.DocumentElement.RemoveChild(nodeToDelete);
            }

            xmlDoc.Save("../../secondCatalogue.xml");
        }
    }
}
