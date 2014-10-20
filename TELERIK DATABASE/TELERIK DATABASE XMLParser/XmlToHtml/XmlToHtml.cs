using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace XmlToHtml
{
    class XmlToHtml
    {
        static void Main(string[] args)
        {
            //and 14
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../Catalogue.xsl");
            xslt.Transform("../../../catalogue.xml", "../../catalogue.html");
        }
    }
}
