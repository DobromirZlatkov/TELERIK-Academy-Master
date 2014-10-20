using System;
class booleanIsFemale
{
    static void Main()
    {
        Console.Write("Enter your gender male or female: ");
        string gender = Console.ReadLine();
        bool isFemale = false;
        if (gender == "female")
        {
            isFemale = true;
        }
        else if (gender == "male")
        {
            isFemale = false;
        }
        if (isFemale == true)
        {
            Console.WriteLine("YOU ARE GIRL");
        }
        else if (isFemale == false)
        {
            Console.WriteLine("YOU ARE BOY");
        }       
    }
}
