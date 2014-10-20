using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllPricesWithLinq
{
    class AllPricesWithLinq
    {
        static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load("../../../catalogue.xml");

            var prices = xmlDoc.Descendants("Album").Where(y => DateTime.Now.Year - int.Parse(y.Element("Year").Value) <= 5).Select(a => a.Element("Price").Value);

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}
