using System;
class ChangeBits
{
    static void Main()
      {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string nBinary = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("result:{0}", nBinary);

        int firstBitPos = 3;
        int secondBitPos = 24;

        for (int i = 3; i < 6; i++)
        {       
            int mask = 1 << firstBitPos;
            int numAndMask = number & mask;
            int firstBit = numAndMask >> firstBitPos;

            int secMask = 1 << secondBitPos;
            int secMaskAndNum = number & secMask;
            int secondBit = secMaskAndNum >> secondBitPos;

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
        string nResult = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine(number);
        Console.WriteLine("Result After:{0}", nResult);
    }
}
