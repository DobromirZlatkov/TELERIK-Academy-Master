namespace LargeCollectionOfProducts
{
    using System;
    using Wintellect.PowerCollections;

    class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<Item> catalog = new OrderedBag<Item>();

            Random random = new Random();
            for (int i = 0; i < 50000; i++)
            {
                catalog.Add(new Item("item" + i, random.Next(0, int.MaxValue)));
            }
            var prices = catalog.FindAll(x => x.Price > 100 && x.Price < 150);

            for (int i = 0; i < 10000; i++)
            {
                int min = random.Next(0, int.MaxValue);
                int max = random.Next(min, int.MaxValue);
                prices = catalog.FindAll(x => x.Price > min && x.Price < max);
            }

            int count = 20;
            foreach (var item in prices)
            {
                Console.WriteLine("name:" + item.Name + "-> price:" + item.Price);
                count -= 1;
                if (count <= 0)
                {
                    break;
                }
            }
        }
    }
}
