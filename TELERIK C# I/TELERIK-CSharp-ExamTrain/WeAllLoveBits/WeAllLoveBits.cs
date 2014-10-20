using System;
class WeAllLoveBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        for (int j = 0; j < k; j++)
        {
            int n = int.Parse(Console.ReadLine());
            string normalNumberAsString = Convert.ToString(n, 2);
            string reversedNumberAsString = "";
            for (int i = normalNumberAsString.Length - 1; i >= 0; i--)
            {
                reversedNumberAsString += normalNumberAsString[i];
            }
            int endResult = Convert.ToInt32(reversedNumberAsString, 2);
            Console.WriteLine(endResult);
        }
       
    }
}
