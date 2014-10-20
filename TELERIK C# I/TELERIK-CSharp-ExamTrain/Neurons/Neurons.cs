using System;
class Neurons
{
    static void Main()
    {
        const uint bit = (uint)1;
        while (true)
        {
            string a = Console.ReadLine();
            if (a == "-1")
            {
                break;
            }
            uint number = uint.Parse(a);
            
            
            uint result = 0;

            bool isInside = false;

            int borders = 0;
            for (int i = 0; i < 32; ++i)
            {
                uint mask = (bit << i);
                uint numAndMas = number & mask;
                if (numAndMas == 0)
                {
                    if (isInside)
                    {
                        result |= mask;
                        continue;
                    }
                    
                }
                else
                {
                    borders++;
                    isInside = !isInside;
                    while (i < 32 && (number & (bit << i) ) != 0)
                    {
                        i++;
                    }
                    i--;
                }
                
            }
            if (borders != 2)
            {
                result = 0;
            }
            Console.WriteLine(result);
           
        }
    }
}
