using System;
class Garden
{
    static void Main()
    {
        int tomatoSeedAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());

        int cucumberSeedAmount = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());

        int potatoSeedAmount = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());

        int carrotSeedAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());

        int cabbageSeedAmount = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());

        int beansSeedsAmount = int.Parse(Console.ReadLine());

        int area = 250;

        decimal totalCostOfSeeds = (tomatoSeedAmount * 0.5M) +
            (cucumberSeedAmount * 0.4M) +
            (potatoSeedAmount * 0.25M) +
            (carrotSeedAmount * 0.6M) +
            (cabbageSeedAmount * 0.3M) +
            (beansSeedsAmount * 0.4M);

        int plantedArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

        Console.WriteLine("Total costs: {0:F2}", totalCostOfSeeds);
        if (area > plantedArea)
        {
            Console.WriteLine("Beans area: {0}", area - plantedArea);
        }
        else if (plantedArea > area)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (plantedArea == area)
        {
            Console.WriteLine("No area for beans");
        }

    }
}
