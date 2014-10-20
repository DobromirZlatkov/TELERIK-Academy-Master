using System;
class MathExpression
{
    static void Main()
    {
        decimal N = decimal.Parse(Console.ReadLine());
        decimal M = decimal.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());
        int asdasd = (int)(M % 180);
        if (M != 0 && P != 0)
        {
            decimal firstPart = (N * N) + (1 / (M * P)) + 1337;
            decimal secondPart = N - (128.523123123m * P);
            decimal thirdPart = (decimal)(Math.Sin(asdasd));

            decimal result = (firstPart / secondPart) + thirdPart;
            Console.WriteLine("{0:f6}",result);
        }
    }
}
