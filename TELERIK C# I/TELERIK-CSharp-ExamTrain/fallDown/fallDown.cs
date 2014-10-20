using System;
class fallDown
{
    static void Main()
    {
        byte[] grid = new byte[8];
        byte input;
        for (int i = 0; i < 8; i++)
        {
            input = byte.Parse(Console.ReadLine());
            byte row = 0;
            while (input > 0)
            {
                byte temp = (byte)(grid[row] & input);
                grid[row] = (byte)(grid[row] | input);
                input = temp;
                row++;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(grid[7 - i]);
        }
    }
}
