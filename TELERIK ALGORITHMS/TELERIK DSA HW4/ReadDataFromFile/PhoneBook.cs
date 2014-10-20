namespace ReadDataFromFile
{
    using System;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class PhoneBook
    {
        private MultiDictionary<string, string> phoneBooks = new MultiDictionary<string, string>(true);
       
        public PhoneBook(string inputFile)
        {
            string[] input = System.IO.File.ReadAllLines(inputFile);

            foreach (var line in input)
            {
                string name = line.Split('|')[0].TrimEnd(' ');
                string town = line.Split('|')[1].TrimEnd(' ');
                string phone = line.Split('|')[2].TrimEnd(' ');
                this.phoneBooks.AddMany(name, new string[] { town, phone });
            }
        }
       
        public void Find(string name)
        {
            if (this.phoneBooks.Keys.Any(key => key.Contains(name)))
            {
                var entry = this.phoneBooks.Keys.Where(key => key.Contains(name));

                foreach (var item in entry)
                {
                    Console.WriteLine("{0} - {1}", item, this.phoneBooks[item]);
                }

            }
            else
            {
                Console.WriteLine("No such item in the phone book!");
            }

        }

        public void Find(string name, string town)
        {
            bool thereIsSuchEntry = false;
            if (this.phoneBooks.Keys.Any(key => key.Contains(name)))
            {
                var entry = this.phoneBooks.Keys.Where(key => key.Contains(name));

                foreach (var item in entry)
                {
                    if (this.phoneBooks[item].ToString().Contains(town))
                    {
                        Console.WriteLine("{0} - {1}", item, this.phoneBooks[item].ToString());
                        thereIsSuchEntry = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("No such item in the phone book!");
            }

            if (thereIsSuchEntry == false) // because there can be such name but no such town
            {
                Console.WriteLine("No such item in the phone book!");
            }
        }    
    }
}
