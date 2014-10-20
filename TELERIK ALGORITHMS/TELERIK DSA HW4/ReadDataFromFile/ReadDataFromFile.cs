using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataFromFile
{
    class ReadDataFromFile
    {
        static void Main(string[] args)
        {

            PhoneBook phonebook = new PhoneBook(@"..\..\input.txt");
            phonebook.Find("Mimi");

            phonebook.Find("Kir", "Va");

            phonebook.Find("Ba", "S");

        }
    }
}
