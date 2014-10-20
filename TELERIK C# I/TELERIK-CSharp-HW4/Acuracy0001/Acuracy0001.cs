using System;
class Acuracy0001
{
    static void Main()
    {
        double a = 2;
        double sum = 1;
        int firstMember = 1;
        while (1 / a > 0.001)
        {
            sum = sum + (1 / a) * firstMember;
            firstMember = firstMember * (-1);
            a++;
        }
        Console.WriteLine("Result : {0:f3}", sum);
    }
}
