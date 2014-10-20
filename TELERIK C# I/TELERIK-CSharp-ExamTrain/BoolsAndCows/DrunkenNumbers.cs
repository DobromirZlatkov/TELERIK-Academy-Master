using System;
class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int j = 0; j < n; j++)
        {
            int input2 = int.Parse(Console.ReadLine());// to remove leading zeroes  
            if (input2 < 0)
            {
                input2 = -input2;
            }
            string input = input2.ToString();
            for (int i = 0; i < (input.Length + 1) / 2; i++)
            {
                int digit = input[i] - '0';               
                leftSum += digit;
            }           
            for (int i = input.Length  / 2; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                if (digit < 0)
                {
                    digit = -digit;
                }
                rightSum += digit;
            }
           
        }
        if (leftSum < rightSum)
        {
            Console.WriteLine("V {0}",rightSum - leftSum);
        }
        else if (leftSum > rightSum)
        {
            Console.WriteLine("M {0}",leftSum - rightSum);
        }
        else if (leftSum == rightSum)
        {
            Console.WriteLine("No {0}",leftSum + rightSum);
        }
    }
}
