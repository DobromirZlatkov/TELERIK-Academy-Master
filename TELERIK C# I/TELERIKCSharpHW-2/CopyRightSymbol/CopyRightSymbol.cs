using System;
class CopyRightSymbol
{
    static void Main()
    {
        Console.Write("Enter height of the pyramyd:");
        int number = int.Parse(Console.ReadLine());

        char symbol = '\u00a9';
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine();
           // Console.WriteLine(symbol);
            for (int j = 0; j < i; j++)
            {
                Console.Write(symbol);
            }
        }
    }
}
