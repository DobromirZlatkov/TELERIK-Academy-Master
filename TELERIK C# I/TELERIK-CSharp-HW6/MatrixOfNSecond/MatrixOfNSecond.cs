using System;
class MatrixOfNSecond
{
    static void Main()
    {
        Console.WriteLine("Enter Number: ");
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col < row + n; col++)
            {
                Console.Write("{0, 3}", col);
            }

            Console.WriteLine();
        }
    }
}
