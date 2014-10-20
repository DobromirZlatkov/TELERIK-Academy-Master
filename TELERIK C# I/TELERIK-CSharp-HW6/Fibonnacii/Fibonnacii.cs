using System;
class Fibonnacii
{
    static void Main()
    {
        Console.WriteLine("Enter fibonacci lenght:");
        int n = int.Parse(Console.ReadLine());

        int firstMember = 0;
        int secondMember = 1;
        int member = 0;

        if (n == 0)
        {
            Console.WriteLine(firstMember);
        }
        else if (n == 1)
        {
            Console.WriteLine(firstMember);
            Console.WriteLine(secondMember);
        }
        else if (n > 1)
        {
            Console.WriteLine(firstMember);
            Console.WriteLine(secondMember);
            for (int i = 2; i <= n; i++)
            {
                member = firstMember + secondMember;
                Console.WriteLine(member);
                firstMember = secondMember;
                secondMember = member;
            }
        }
    }
}
