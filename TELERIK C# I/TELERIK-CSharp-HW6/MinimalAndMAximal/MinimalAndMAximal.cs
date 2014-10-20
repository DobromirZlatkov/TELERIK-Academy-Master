using System;
class MinimalAndMAximal
{
    static void Main()
    {
        Console.WriteLine("How many numbers you want to enter:");
        int n = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Number {0}",i + 1);
            int number = int.Parse(Console.ReadLine());
            numbersArray[i] = number;

        }

        Array.Sort(numbersArray);
        Console.WriteLine("minimal number is :{0}", numbersArray[0]);
        Console.WriteLine("maximal number is :{0}", numbersArray[numbersArray.Length - 1]);
    }
}
