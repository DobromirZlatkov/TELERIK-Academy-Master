using System;
class IsThirdDigit7
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            bool thirdBit = false;

            for (int i = 0; i < 8; i++)
            {
                int bit = (n >> i) & 1;
                if (i == 2)
                {
                    if (bit == 1)
                    {
                        thirdBit = true;
                    }
                }
                Console.WriteLine(bit);
            }

            Console.WriteLine("Third bit is: {0} ", thirdBit);
            
        }
    }
}
