using System;
class ASCIItable
{
    static void Main()
    {
        

        for (int i = 0; i < 257; i++)
        {
            string hexValue = i.ToString("X");
            char charValue = (char)i;
            Console.WriteLine("Dec: {0} | Hex: {1} | Char: {2}", i, hexValue, charValue);
        }
    }
}
