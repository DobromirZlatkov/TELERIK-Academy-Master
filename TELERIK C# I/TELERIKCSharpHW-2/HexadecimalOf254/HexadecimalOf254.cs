using System;
class HexadecimalOf254
{
    static void Main()
    {
        while (true)
        {                 
            Console.Write("Enter number in decimal:");
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("X");       
            Console.WriteLine("Hexadecimal of the number:{0}",hexValue);
       }
    
    }
}
