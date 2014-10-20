using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextToXml
{
    class TextToXml
    {
        static void Main(string[] args)
        {
            string filepath = @"..\..\person.xml";
            string[] lines = File.ReadAllLines(@"..\..\Person.txt");
            string name = lines[0];
            string address = lines[1];
            string phoneNumber = lines[2];

            XElement person = new XElement("Person",
                    new XElement("name", name),
                    new XElement("address", address),
                    new XElement("phoneNumber", phoneNumber));

            person.Save(@"..\..\person.xml");
        }
    }
}
