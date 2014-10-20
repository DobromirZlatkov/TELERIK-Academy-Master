using System;
class First10MenmbersOfSequence
{
    static void Main()
    {
        Console.Write("Enter sequence lenght");
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            int result = i;
            if (i % 2 > 0)
            {
                result = -i;
            }          
            Console.WriteLine(result);
        }
    }
}

