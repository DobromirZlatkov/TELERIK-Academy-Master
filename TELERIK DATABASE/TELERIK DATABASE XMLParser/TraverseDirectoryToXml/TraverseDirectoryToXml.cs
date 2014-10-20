using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TraverseDirectoryToXml
{
    class TraverseDirectoryToXml
    {
        static void Main(string[] args)
        {
            string filePath = "../../directory.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            string directory = @"E:\Programing";

            using (XmlTextWriter writer = new XmlTextWriter(filePath, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("directories");

                CreateXMLForDirectory(directory, writer);

                writer.WriteEndDocument();
            }
        }

        public static void CreateXMLForDirectory(string sourceDirectory, XmlTextWriter writer)
        {
            FileInfo fileInfoSource = new FileInfo(sourceDirectory);

            writer.WriteStartElement("directory");
            writer.WriteAttributeString("name", fileInfoSource.Name);

            var files = Directory.EnumerateFiles(sourceDirectory);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                writer.WriteStartElement("file");
                writer.WriteElementString("name", fileInfo.Name);
                writer.WriteElementString("type", fileInfo.Extension);
                writer.WriteEndElement();
            }

            var directories = Directory.EnumerateDirectories(sourceDirectory);
            foreach (var directory in directories)
            {

                CreateXMLForDirectory(directory, writer);

            }

            writer.WriteEndElement();
            
        }
    }
}
