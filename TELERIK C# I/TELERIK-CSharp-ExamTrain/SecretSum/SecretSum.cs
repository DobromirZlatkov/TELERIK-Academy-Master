using System;
using System.Numerics;
class SecretSum
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        if (number < 0)
        {
            number = -number;
        }
        string sequienceLenght = number.ToString();
        BigInteger digitCounter = 0;
        BigInteger specialSum = 0;
        BigInteger number2 = number;
        for (int i = 0; i < sequienceLenght.Length ; i++)
        {
            BigInteger digit = number % 10;
            number = number / 10;
            digitCounter++;
            if (digitCounter % 2 == 0)
            {
                specialSum += (digit * digit) * digitCounter;
            }
            else
            {
                specialSum += digit * (digitCounter * digitCounter);
            }
            
        }        

        BigInteger letterSequenceLenght = specialSum % 10;
        if (letterSequenceLenght == 0)
        {
            Console.WriteLine(specialSum);
            Console.WriteLine(number2 + " has no secret alpha-sequence");
        }
        else
        {
            BigInteger R = specialSum % 26;
            BigInteger letterSequenceStart = R + 1;
            Console.WriteLine(specialSum);
            for (int i = 0; i < letterSequenceLenght; i++)
            {
                char a = (char)(64 + letterSequenceStart);
                Console.Write(a);
                letterSequenceStart++;
                if (letterSequenceStart > 26)
                {
                    letterSequenceStart = 1;
                }
            }
        }     
    }
}
