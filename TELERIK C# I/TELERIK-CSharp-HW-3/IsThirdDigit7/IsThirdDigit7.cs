using System;
class IsThirdDigit7
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            bool isSeven = false;
            for (int i = 0; i < 2; i++)
            {
                n = n / 10;           
            }
            int thirdDigit = n % 10;
            if (thirdDigit == 7)
            {
                isSeven = true;
            }
            Console.WriteLine(isSeven);
            Console.WriteLine(new string('-',40));
        }
        
    }
}

