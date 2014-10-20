using System;
class dancingBits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string dancinBits = "";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string numberAsString = Convert.ToString(number, 2);
            dancinBits += numberAsString;           
        }
        int zeroCount = 0;
        int oneCount = 0;
        int sequenceCOunt = 0;
        for (int i = 0; i < dancinBits.Length;)
        {
            while (dancinBits[i] == '1' && i < dancinBits.Length)
            {
                
                oneCount++;
                if (oneCount == K)
                {
                    sequenceCOunt++;
                }
                else if (oneCount - K == 1)
                {
                    sequenceCOunt--;
                }
                if (i + 1 < dancinBits.Length)
                {
                    i++;
                }
                else
                {
                    break;     
                }
                
            }           
            while (dancinBits[i] == '0' && i < dancinBits.Length)
            {               
                zeroCount++;
                if (zeroCount == K)
                {
                    sequenceCOunt++;
                }
                else if (zeroCount - K == 1)
                {
                    sequenceCOunt--;
                }
                if (i + 1 < dancinBits.Length)
                {
                   i++; 
                }
                else
                {
                    break;
                }
                
            }
           
            oneCount = 0;
            zeroCount = 0;
            if (i == dancinBits.Length - 1)
            {
                i++;
            }
            
        }
        Console.WriteLine(sequenceCOunt);
    }
}
