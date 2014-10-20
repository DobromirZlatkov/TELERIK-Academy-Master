using System;
class Program
{
    static void Main()
    {
        string firstMember = Console.ReadLine();
        int first = (int)firstMember[0] - 64;
        string secondMember = Console.ReadLine();
        int second = (int)secondMember[0] - 64;

        int numberRows = int.Parse(Console.ReadLine());
        Console.WriteLine((char)(first + 64));
        if (numberRows > 1)
        {
            int next = first + second;
            if (next > 26)
            {
                next %= 26;
            }
            string result = ((char)(second + 64)).ToString() + 
                ((char)(next + 64)).ToString();
            Console.WriteLine(result);
            first = second;
            second = next;

            for (int i = 3; i <= numberRows; i++)
            {
                if (next > 26)
                {
                    next %= 26;
                }
                next = first + second;
                if (next > 26)
                {
                    next %= 26;
                }
                first = second;
                second = next;
                next = first + second;
                if (next > 26)
                {
                    next %= 26;
                }
                first = second;
                second = next;
                Console.Write((char)(first + 64));
                Console.Write(new string(' ', i - 2));
                Console.WriteLine((char)(second + 64));
            }
        }
       
    }
}
