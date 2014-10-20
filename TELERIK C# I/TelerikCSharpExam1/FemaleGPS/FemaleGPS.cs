using System;
class FemaleGPS
{
    static void Main()
    {

        long n = long.Parse(Console.ReadLine());
        if (n < 0)
	    {
		     n = -n;
	    }
        string nAsString = Convert.ToString(n);
        long sumOdd = 0;
        long sumEven = 0;
        for (int i = 0; i < nAsString.Length; i++)
        {
            int digit = nAsString[i] - '0';
            if (digit % 2 == 0)
            {
                sumEven += digit;
            }
            else
            {
                sumOdd += digit;
            }
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("straight " + sumEven);
        }
        else if (sumOdd > sumEven)
        {
            Console.WriteLine("left " + sumOdd);
        }
        else if (sumEven > sumOdd)
        {
            Console.WriteLine("right " + sumEven);
        }
    }
}
