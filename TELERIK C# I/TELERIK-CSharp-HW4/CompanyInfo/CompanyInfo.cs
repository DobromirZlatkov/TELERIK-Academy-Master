using System;
class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name:");
        string compName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string compNumber = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string compFax = Console.ReadLine();
        Console.Write("Enter company web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("C O M P A N Y INFO");
        Console.WriteLine("Name:{0}",compName);
        Console.WriteLine("Address:{0}",compAddress);
        Console.WriteLine("Phone number:{0}",compNumber);
        Console.WriteLine("FAX number:{0}",compFax);
        Console.WriteLine("Web site:{0}",webSite);
        Console.WriteLine("M A N A G E R INFO");
        Console.WriteLine("First name:{0}",managerFirstName);
        Console.WriteLine("Last name:{0}", managerLastName);
        Console.WriteLine("Age:{0}",managerAge);
        Console.WriteLine("Phone number:{0}",managerPhone);





    }
}
