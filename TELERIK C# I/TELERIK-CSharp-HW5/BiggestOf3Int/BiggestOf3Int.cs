using System;
class BiggestOf3Int
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integers:");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            if (n1 > n3)
            {
                Console.WriteLine("Biggest number is:{0}", n1);
            }
        }
        else if (n1 == n2)
        {
            if (n1 > n3)
            {
                Console.WriteLine("Number {0} and {1} are equal and bigger than {2}", n1,n2,n3);
            }
        }
        if (n2 > n1)
        {
            if (n2 > n3)
            {
                Console.WriteLine("Biggest number is:{0}",n2);
            }
        }
        if (n3 > n1)
        {
            if (n3 > n2)
            {
                Console.WriteLine("Biggest number is:{0}", n3);
            }
        }
        else if (n1 == n3)
        {
            if (n1 > n2)
            {
                Console.WriteLine("Number {0} and {1} are equal and bigger than {2}", n1, n3, n2);
            }
        }
        if (n1 == n2 && n1 == n3 )        
        {
            Console.WriteLine("Numbers are equal");
        }
    }
}
