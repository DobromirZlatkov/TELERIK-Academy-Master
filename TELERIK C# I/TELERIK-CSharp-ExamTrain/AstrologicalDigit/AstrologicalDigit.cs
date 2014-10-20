using System;
class AstrologicalDigit
{
    static void Main()
    {
       
        string number = Console.ReadLine();
        if (number.Length == 1)
        {
            Console.WriteLine(number);
            return;
        }
        int astrologicalDigit = 0;
        while (number.Length > 1)
        {
            astrologicalDigit = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '.' || number[i] == '-')
                {
                    continue;
                }
                astrologicalDigit += number[i] - '0';
            } 
            number = astrologicalDigit.ToString();
        }
        
        Console.WriteLine(astrologicalDigit);
    }
}
