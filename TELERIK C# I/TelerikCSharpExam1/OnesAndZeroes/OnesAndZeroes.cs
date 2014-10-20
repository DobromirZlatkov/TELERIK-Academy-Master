using System;
class OnesAndZeroes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // edinica
      
        string nAsString = Convert.ToString(n, 2).PadLeft(32, '0');
        
        int[] arrayBits = new int[16];

        for (int i = 0; i < 16; i++)
        {
            arrayBits[i] = (n >> i) & 1;
        }
        for (int k = 0; k < 5; k++)
        {
            for (int i = arrayBits.Length -1; i >= 0; i--)
            {
                //int bit = (n >> i) & 1;


                if (arrayBits[i] == 1 && k == 0)
                {
                    Console.Write(".");
                    Console.Write("#");
                    Console.Write(".");
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                   
                }
                else if (arrayBits[i] == 0 && k == 0)
                {
                    Console.Write("#");
                    Console.Write("#");
                    Console.Write("#");
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.Write(".");
                    }
                                    
                }
                if (arrayBits[i] == 1 && k == 1)
                {
                    Console.Write("#");
                    Console.Write("#");
                    Console.Write(".");
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                else if (arrayBits[i] == 0 && k == 1)
                {
                    Console.Write("#");
                    Console.Write(".");
                    Console.Write("#");
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                if (arrayBits[i] == 1 && k == 2)
                {
                    Console.Write(".");
                    Console.Write("#");
                    Console.Write(".");
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                else if (arrayBits[i] == 0 && k == 2)
                {
                    Console.Write("#");
                    Console.Write(".");
                    Console.Write("#");
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.Write(".");
                    }
                   
                }
                if (arrayBits[i] == 1 && k == 3)
                {
                    Console.Write(".");
                    Console.Write("#");
                    Console.Write(".");
                    if (i == 0)
                    {

                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                else if (arrayBits[i] == 0 && k == 3)
                {
                    Console.Write("#");
                    Console.Write(".");
                    Console.Write("#");
                    if (i == 0)
                    {
                        
                    }
                    else
                    {
                        Console.Write("."); 
                    }
                    
                   
                }
                if (arrayBits[i] == 1 && k == 4)
                {
                   
                    if (i == 0)
                    {
                        Console.Write("#");
                        Console.Write("#");
                        Console.Write("#");
                        continue;
                    }
                    else
                    {
                        Console.Write("#");
                        Console.Write("#");
                        Console.Write("#");
                        Console.Write(".");
                    }
                    
                    
                }
                else if (arrayBits[i] == 0 && k == 4)
                {

                    if (i == 0)
                    {
                        Console.Write("#");
                        Console.Write("#");
                        Console.Write("#");
                        continue;
                    }
                    else
                    {
                            Console.Write("#");
                            Console.Write("#");
                            Console.Write("#");
                            Console.Write(".");
                    }
                   
                   
                    
                }
                if (i == 0)
                {
                    Console.WriteLine();
                }
            }
        }          
    }
}

