using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TraverseDirectoryToXmlWithXElement
{
    class TraverseDirectoryToXmlWithXElement
    {
        static void Main(string[] args)
        {
            XElement xmldir = new XElement("directories", CreateXMLForDirectory(@"E:\Programing"));
            xmldir.Save("../../allDirectories.xml");
        }

        public static XElement CreateXMLForDirectory(string sourceDirectory)
        {
            FileInfo fileInfoSource = new FileInfo(sourceDirectory);

            XElement roothDirectory = new XElement("directory",
            new XAttribute("name", fileInfoSource.Name));

            var files = Directory.EnumerateFiles(sourceDirectory);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                roothDirectory.Add(new XElement("file"),
                    new XElement("name", fileInfo.Name),
                    new XElement("type", fileInfo.Extension)
                    );

            }

            var directories = Directory.EnumerateDirectories(sourceDirectory);
            foreach (var directory in directories)
            {

                roothDirectory.Add(CreateXMLForDirectory(directory));

            }

            return roothDirectory;
        }
    }
}
