using System;
class falldown2
{
    static void Main()
    {
        char[,] matrix = new char[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string numberTostring = Convert.ToString(number, 2).PadLeft(8, '0');
            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = numberTostring[j]; 
            }
        }
      
        for (int i = 0; i < 8; i++)
        {
            for (int row = 7 - 1; row >= 0; row--)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (matrix[row, col] == '1' && matrix[row + 1, col] == '0')
                    {
                        matrix[row, col] = '0';
                        matrix[row + 1, col] = '1';
                    }
                }
            }
        }
        
        string result = "";

        for (int i = 0; i < 8; i++)
        {
            result = "";
            for (int j = 0; j < 8; j++)
            {
                result += matrix[i, j];  
            }

            byte END = Convert.ToByte(result, 2);
            Console.WriteLine(END);
        }
    }
}
