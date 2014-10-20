using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;

namespace ForumRSS
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Task1 and Task2
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://forums.academy.telerik.com/feed/qa.rss", "../../../RSS.xml");
           
            //Task3
            XElement element = XElement.Load("../../../RSS.xml");
            string xmlToJson = JsonConvert.SerializeXNode(element, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"../../rss.json", xmlToJson);

            //Task4
            JObject jsonObject = JObject.Parse(xmlToJson);

            var allQuestionTitles = jsonObject["rss"]["channel"]["item"].Select(t => t["title"]);

            //foreach (var questionTitle in allQuestionTitles)
            //{
            //    Console.WriteLine(questionTitle);
            //}

            //Task5
            var itemFromRssAsJson = jsonObject["rss"]["channel"]["item"].ToString();
            var poco = JsonConvert.DeserializeObject<Item[]>(itemFromRssAsJson);

            //Task6
            StringBuilder html = new StringBuilder("<body>\n\t<ul>\n");

            foreach (var item in poco)
            {
                html.AppendLine("\t\t<li>Question : " + item.Title + " Category : " + item.Category + "Link : " + item.Link + "Date : " + item.PubDate + "</li>");
            }
            html.AppendLine("\t</ul>\n</body>");
            string htmlPage = html.ToString();
            Console.WriteLine(html);
            File.WriteAllText(@"../../rss.html", htmlPage);
        }
    }
}
