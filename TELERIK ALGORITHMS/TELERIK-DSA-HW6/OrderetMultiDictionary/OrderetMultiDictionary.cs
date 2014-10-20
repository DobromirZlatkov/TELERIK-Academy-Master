using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace OrderetMultiDictionary
{
    class OrderetMultiDictionary
    {
        static void Main(string[] args)
        {
            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);

            //add articles
            for (int i = 0; i < 10000000; i++)
            {
                double price = i * 0.2;
                int barcode = i ^ 34;
                string vendor = "vendor" + i.ToString();
                string title = "Title" + i.ToString();
                articles.Add(price, new Article(barcode, price, vendor, title));
            }

            var articlesInRange = GetArticlesInPriceRange(articles, 100d, 1000d);


            foreach (var article in articlesInRange)
            {
                foreach (var item in article.Value)
                {
                    Console.WriteLine("price: {0} ==> name: {1} | barcode: {2}", item.Price, item.Title, item.Barcode);
                }
            }

        }

        static OrderedMultiDictionary<double, Article>.View GetArticlesInPriceRange(OrderedMultiDictionary<double, Article> articles, double low, double high)
        {
            return articles.Range(low, true, high, false);
        }
    }
}
