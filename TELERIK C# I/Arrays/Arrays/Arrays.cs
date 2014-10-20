using System;
using System.Collections.Generic;
class Arrays
{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };
        int[] old = arr;
        arr = new int[4];

        for (int i = 0; i < old.Length; i++)
        {
            arr[i] = old[i];
        }
        arr[3] = 5;



        List<int> clothes = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            clothes.Add(i);
        }


        List<string> listOfStrings = new List<string>();
        string[] arrayOfStrings = {"Pesho", "ivan","dobri", "gosho"};

        foreach (string str in arrayOfStrings)
        {
            listOfStrings.Add(str);
        }
        Console.WriteLine(new string('-',20));

        foreach (string str in listOfStrings)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine(new string('-', 20));

        //string input = Console.ReadLine();
        //while (input != "stop")
        //{
        //    listOfStrings.Add(input);
        //    input = Console.ReadLine();
            
        //}

        for (int i = 0; i < listOfStrings.Count; i++)
        {
            Console.WriteLine(listOfStrings[i]);
        }
        Console.WriteLine();


        List<int> list = new List<int>();

        string COnsoleLine = Console.ReadLine();

        int n = int.Parse(Console.ReadLine());
        string linebreak = new string('-', 20);
        for (int i = 0; i < n + 1; i++)
        {
            var capacity = list.Capacity;
            var count = list.Count;
            Console.WriteLine("Capacity:{0} // Count: {1}\n{2}",
                capacity, count, linebreak);
            list.Add(i);
        }


        // copirane na masivi
        // array.clone(); array.Copy(10);
    }
}
