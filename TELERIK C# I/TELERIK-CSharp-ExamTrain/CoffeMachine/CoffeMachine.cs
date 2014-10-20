using System;
class CoffeMachine
{
    static void Main()
    {
        int countOf5Coins = int.Parse(Console.ReadLine());
        int countOf10Coins = int.Parse(Console.ReadLine());
        int countOf20Coins = int.Parse(Console.ReadLine());
        int countOf50Coins = int.Parse(Console.ReadLine());
        int countOf100Coins = int.Parse(Console.ReadLine());


        decimal moneyInPut = decimal.Parse(Console.ReadLine());
        decimal drinkCost = decimal.Parse(Console.ReadLine());
        decimal changeMoney = moneyInPut - drinkCost;

        if (changeMoney < 0)
        {
            Console.WriteLine("More {0:f2}", -changeMoney);
        }
        else
        {
            decimal machineMoney = 0.05M * countOf5Coins + 0.10m * countOf10Coins
                + 0.20m * countOf20Coins + 0.50m * countOf50Coins + 1.00m * countOf100Coins;
            if (machineMoney >= changeMoney)
            {
                Console.WriteLine("Yes {0:f2}", machineMoney - changeMoney);
            }
            else
            {
                Console.WriteLine("No {0:f2}", changeMoney - machineMoney);
            }
        }
    }
}
