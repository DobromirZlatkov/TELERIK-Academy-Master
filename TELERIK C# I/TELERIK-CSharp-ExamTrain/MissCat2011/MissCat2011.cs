using System;
class Program
{
    static void Main()
    {
        int[] cats = new int[11];
        int judjes = int.Parse(Console.ReadLine());

        for (int i = 0; i < judjes; i++)
        {
            int votes = int.Parse(Console.ReadLine());
            cats[votes]++;
        }

        int result = 0;
        int max = 0;

        for (int i = 0; i < cats.Length; i++)
        {
            int currentValue = cats[i];

            if (max < currentValue)
            {
                max = currentValue;
                result = i;
            }
        }
        Console.WriteLine(result);

    }
}