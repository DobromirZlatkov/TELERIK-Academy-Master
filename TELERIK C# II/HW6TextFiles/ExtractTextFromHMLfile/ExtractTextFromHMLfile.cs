using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _10_XMLExtract
{
    class Program
    {
           /*Write a program that extracts from given XML 
         * file all the text without the tags. Example:
         * <?xml version="1.0"><student><name>Pesho</name>
         * <age>21</age><interests count="3"><interest> 
         * Games</instrest><interest>C#</instrest><interest> 
         * Java</instrest></interests></student>

        */
        // all text files are in directory where is .cs
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("hmlText.xml");
            string contents = "";
            while (reader.Read())
            {
                reader.MoveToContent();
                if (reader.NodeType == XmlNodeType.Text)
                {
                    contents += reader.Value + "\n";
                }
            }
            Console.Write(contents);
        }
    }
}