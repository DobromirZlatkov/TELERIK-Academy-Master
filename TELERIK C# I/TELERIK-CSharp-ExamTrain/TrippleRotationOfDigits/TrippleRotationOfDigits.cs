using System;
class TrippleRotationOfDigits
{
    static void Main()
    {
        
            int k = int.Parse(Console.ReadLine());
            int number;
            int digit = 0;
            int newNumber = 0;         
            for (int i = 0; i < 3; i++)
            {
                number = k % 10;
                if (number==0)
                {
                    k = k / 10;
                }
                else
                {
                    digit = number;
                    newNumber = int.Parse(digit.ToString() + k.ToString());
                    k = newNumber / 10;
                }
            }
            Console.WriteLine(k);              
    }
}
