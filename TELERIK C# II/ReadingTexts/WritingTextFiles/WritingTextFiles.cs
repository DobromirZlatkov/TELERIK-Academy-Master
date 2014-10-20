using System;
using System.IO;

class WritingTextFiles
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        string fileName = "numbers.txt";
        StreamWriter streamWriter = new StreamWriter(fileName);
        streamWriter.AutoFlush = false;
        using (streamWriter)
        {
            for (int number = 1; number <= 200000; number++)
            {
                streamWriter.WriteLine(number);                   
            }
        }
        DateTime later = DateTime.Now;
        
        Console.WriteLine(later - now);
        Console.WriteLine("File is written!");
    }
}
