using System;
class NaBabaMi
{
    static void Main()
    {

        int smetaloWidth = int.Parse(Console.ReadLine());

        char[,] matrix = new char[8, smetaloWidth];

        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string numberTostring = Convert.ToString(number, 2).PadLeft(smetaloWidth, '0');
            for (int j = 0; j < smetaloWidth; j++)
            {
                matrix[i, j] = numberTostring[j];
            }
        }
       
        string commands = "";
        int row1 = 0;
        int col1 = 0;
        int row = 0;
        int col = 0;
        while (commands != "stop")
        {
            commands = Console.ReadLine();
            if (commands=="left" || commands=="right")
            {
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
            }
            

            // ako e resset
            if (commands == "reset")
            {
                
                for (int j = 0; j < 8 ; j++)
                {
                    int bitCOunt = 0;
                    for (int k = 0; k < smetaloWidth; k++)
                    {
                        if (matrix[j,k] == '1')
                        {
                            matrix[j, k] = '0';
                            bitCOunt++;
                        }
                            
                    }
                    for (int u = 0; u < bitCOunt; u++)
                    {
                        matrix[j, u] = '1';
                    }
                }
            }
                // za left
                int leftCounter = 0;
                if (commands == "right")
                {
                    if (matrix[row, col] == '1' || matrix[row, col] == '0') // ako e ocelila
                    {
                        while (col > 0)
                        {
                            col--;
                            if (matrix[row, col] == '1')
                            {
                                matrix[row, col] = '0';
                                leftCounter++;
                            }
                        }

                        for (int i = leftCounter; i >= 0; i--)
                        {
                            matrix[row, i] = '1';
                        }
                    }
                
                }
                //righty

                int rightCOunter = 0;
                if (commands == "left")
                {
                    if (matrix[row, col] == '1' || matrix[row, col] == '0') // ako e ocelila
                    {
                        while (col < smetaloWidth - 1)
                        {
                            col++;
                            if (matrix[row, col] == '1')
                            {
                                matrix[row, col] = '0';
                                rightCOunter++;
                            }
                        }
                        for (int i = 0; i < rightCOunter; i++)
                        {
                            matrix[row, i] = '1';
                        }
                       
                    }

                }
               
            }

        int drug = 0;
        int temp = 0;
        string result = "";
        for (int i = 0; i < 8; i++)
        {
            int papaz = 0;
            result = "";
            for (int j = 0; j < smetaloWidth; j++)
            {
                result += matrix[i, j];
                if (matrix[i, j]=='1')
                {
                    papaz++;
                }
            }
            int end = Convert.ToInt32(result, 2);
            temp += end;
            if (papaz == 0)
            {
                drug++;
            }

        }
        Console.WriteLine(temp);

        
    }
}
