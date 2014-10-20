using System;
class Bitris
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        int numberOfShapes = numberOfLines / 4;

        for (int ii = 0; ii < numberOfShapes; ii++)
        {
            int shape = int.Parse(Console.ReadLine());
            string commands = Console.ReadLine() + 
                              Console.ReadLine() +
                              Console.ReadLine() +
                              Console.ReadLine();

        }
    }
}
