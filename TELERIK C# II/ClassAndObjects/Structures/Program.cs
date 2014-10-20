using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    

    class Program
    {
        

        private const string CapitalLeters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters =
            "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=-`[]{}\\|<>,./?";
        private const string AllChars = CapitalLeters + SmallLetters + Digits + SpecialChars;
        private static Random rnd = new Random();
        

        static void Main(string[] args)
        {
           
            StringBuilder password = new StringBuilder();
            for (int i = 1; i <= 2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLeters);
                InsertAtRandomPosition(password, capitalLetter);
            }
            for (int i = 0; i <= 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);

            for (int i = 0; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPosition(password, specialChar);
            }
            int count = rnd.Next(8);
            for (int i = 1; i < count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, specialChar);
            }
            Console.WriteLine(password);
        }

        private static void InsertAtRandomPosition(StringBuilder password, char specialChar)
        {
            int randomPosition = rnd.Next(password.Length + 1);
            password.Insert(randomPosition, specialChar);
        }
        private static char GenerateChar(string availableChars)
        {
            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
        //pravene na parola
     
    }
}
