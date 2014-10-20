using System;
class sheets2
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int[] sheetValue = new int[11]
            {
                1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1
            };


        for (int i = 0; i < sheetValue.Length; i++)
        {
            if (input < sheetValue[i])
            {
                Console.WriteLine("A" + i);
            }
            else
            {
                input -= sheetValue[i];
            }
        }
    }
}
