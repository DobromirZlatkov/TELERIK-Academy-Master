using System;
class LeastMajorityMultiple
{
    static void Main()
    {
        int[] numbers = new int[5];
        bool bbreak = false;
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        for (int i = 2; i < 200000000; i++)
        {
            counter = 0;
            for (int j = 0; j < 5; j++)
            {
                
                if (i % numbers[j] == 0)
                {
                    counter++;
                    if (counter >= 3)
                    {
                        Console.WriteLine(i);
                        bbreak = true;
                        break;
                    }
                }
            }
            if (bbreak)
            {
                break;
            }
        }
    }
}
