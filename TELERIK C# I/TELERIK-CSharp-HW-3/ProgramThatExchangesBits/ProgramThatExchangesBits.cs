using System;
class ProgramThatExchangesBits
{
    static void Main()
    {
        Console.Write("Enter Number:");
        int number = int.Parse(Console.ReadLine());
        string numberBits = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("Number before exchange:{0}", numberBits);
        Console.Write("Enter number of bits you want to exchange: ");
        int howMuchBitsToChange = int.Parse(Console.ReadLine());
        Console.Write("Enter the start of the first sequence of bits:");
        int firstBitPos = int.Parse(Console.ReadLine());
        int start = firstBitPos;
        Console.Write("Enter the start of the second sequence of bits:");
        int secondBitPos = int.Parse(Console.ReadLine());

        if ((howMuchBitsToChange > 16))
        {
            Console.WriteLine("The number is 32 bits so you can change max 16 bits.");
        }
        else if ((firstBitPos + howMuchBitsToChange) > 16)
        {
            Console.WriteLine("number of bits you want to change + first bit possition should not be geater than 16.");
        }
        else
        {       
            for (int i = start; i <= howMuchBitsToChange; i++)
            {
                int mask = 1 << firstBitPos;
                int numAndMask = number & mask;
                int firstBit = numAndMask >> firstBitPos;

                int secMask = 1 << secondBitPos;
                int numAndSecMask = number & secMask;
                int secondBit = numAndSecMask >> secondBitPos;

                int temp = firstBit;
                firstBit = secondBit;
                secondBit = temp;
                if (firstBit == 1)
                {
                    mask = 1 << firstBitPos;
                    number = number | mask;
                }
                else
                {
                    mask = ~(1 << firstBitPos);
                    number = number & mask;
                }
                if (secondBit == 1)
                {
                    mask = 1 << secondBitPos;
                    number = number | mask;
                }
                else
                {
                    mask = ~(1 << secondBitPos);
                    number = number & mask;
                }
                firstBitPos++;
                secondBitPos++;

            }
            string nExchange = Convert.ToString(number, 2).PadLeft(32,'0');
            Console.WriteLine(number);
            Console.WriteLine("Number after exchange bits: {0}", nExchange);
         } 
    }
}
