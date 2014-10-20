using System;
class Carpets
{
    static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n / 2 - 1;
            string leftside = "/";          //variable which will print the "/"
            string rightside = "\\";        //variable which will print the "\"
            int stringlength;
            // We print the 1st line cause it will be the same for every N
            Console.Write(new string('.', dots) + leftside + new string(' ', 0) + rightside + new string('.', dots));
            Console.WriteLine();
            dots--;
            // Then we do a for loop for half of the Rhomb
 
            for (int i =2; i <= n/2; i++)
            {
            // For each even row we add 2 spaces
                 if (i % 2 == 0)
                 {
                 Console.Write(new string('.', dots) + leftside + new string(' ', 2) + rightside + new string('.', dots));
                 Console.WriteLine();
                 dots--;
                 }
                //For each odd row which will be the start of a new rhomb we don't add spaces
                 else
                 {
                 leftside = leftside + " /"; // and we add " /" to the left side
                 rightside = rightside + " \\"; //and " \" to the right side
                 Console.Write(new string('.', dots) + leftside + rightside + new string('.', dots));
                 Console.WriteLine();
                 dots--;
                 }
            }
            dots = 0;
        //Analogical to the first loop we do the same but in reverse for the second part of the Rhomb
              for (int i = n/2; i >=2; i--)
              {
                   if (i % 2 == 0)
                   {
                    Console.Write(new string('.', dots) + rightside + new string(' ', 2) + leftside + new string('.', dots));
                    Console.WriteLine();
                    dots++;
                    }
                   else
                    {
 
                   Console.Write(new string('.', dots) + rightside + leftside + new string('.', dots));
                   Console.WriteLine();
                   dots++;
       // here we get the lenght of the string and remove the last 2 symbols " /"
                  stringlength = leftside.Length;
                  leftside = leftside.Remove(stringlength -2, 2);
 
        // we do the same for the other string
                 stringlength = rightside.Length;
                 rightside = rightside.Remove(stringlength - 2, 2);
                     }
               }
     //printing the last row of the rhomb again
         Console.Write(new string('.', dots) + rightside + new string(' ',0) + leftside + new string('.', dots));
       }
}
