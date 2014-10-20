using System;
class ExelColumn
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());


        //int AC = 26 + 3;
        //int AZ = 26 + 26;
        //int BC = 26 * 2 + 3;
        //int ZZ = 26 * 26 + 26;
        //int AAB = 26 * 26 + 26 + 2;
        //int AAZ = 26 * 26 + 26 * 2;
        //int ABC = 26 * 26 + 26 * 2 + 3;

        //int BAB = (26 * 26 * 2) + 26 + 2;

        //int BBB = (26 * 26 * 2) + (26 * 2) + 2;

        //int ZZB = (26 * 26 * 26) + (26 * 26) + 2;
        //int XEY = (26 * 26 * 24) + (26 * 5) + 25;
        //int CECA = (26 * 26 * 26 * 3) + (26 * 26 * 5) + (26 * 3) + 1;

        char[] input = new char[N];

        double result = 0;
        for (int u = N - 1; u >= 0; u--)
        {
            input[u] = char.Parse(Console.ReadLine());                        
        }
        for (int i = 0; i < input.Length; i++)
        {
            result += ((int)input[i] - 64) * Math.Pow(26, i);
        }
        Console.WriteLine(result);
    }
}
