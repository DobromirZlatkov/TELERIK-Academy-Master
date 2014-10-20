using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AllPricesFromCatalog
{
    class AllPricesFromCatalog
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\..\catalogue.xml");
            string xPathQuery = "/Catalogue/Album";

            XmlNodeList albumsList = doc.SelectNodes(xPathQuery);
            var currentYear = DateTime.Now.Year;
            foreach (XmlNode node in albumsList)
            {
                int year = int.Parse(node.SelectSingleNode("Year").InnerText);
                if (currentYear - year >= 5)
                {
                    decimal price = decimal.Parse(node.SelectSingleNode("Price").InnerText);
                    Console.WriteLine(price);
                }
            }

        }
    }
}
