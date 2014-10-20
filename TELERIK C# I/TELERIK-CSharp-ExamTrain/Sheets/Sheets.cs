using System;
class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
              
        
        int[] sheets = new int[11];
        int[] check = new int[11];
        int counter = 0;
        int papa = 10;
        for (int i = 0; i < sheets.Length; i++)
        {
            int papaz = 1;
            papaz = papaz << i;
            sheets[i] = papaz;
            check[i] = papaz;
        }
        if (n > 1024)
        {
            n = n % sheets[10];
            sheets[10]++;
        }
        while (n > 0)
        {
            if (sheets[counter] > n)
            {
                n = n % sheets[counter - 1];
                sheets[counter - 1]++; 
                counter = 0;                
            }
            counter++;
        }
        for (int i = 0; i < sheets.Length ; i++)
        {
            if (sheets[i]==check[i])
            {
                Console.WriteLine("A{0}",papa);
            }
            papa--;
        }
        
    }
}
