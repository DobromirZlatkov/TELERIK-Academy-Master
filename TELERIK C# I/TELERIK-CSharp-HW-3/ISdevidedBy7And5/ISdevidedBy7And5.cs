using System;
class ISdevidedBy7And5
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            bool isDivided = false;
            if (n % 7 == 0 && n % 5 == 0)
            {
                isDivided = true;
            }
            Console.WriteLine("Number is divided by 7 and 5 : {0}",isDivided);
            Console.WriteLine(new string('-', 40));
        }        
    }
}
