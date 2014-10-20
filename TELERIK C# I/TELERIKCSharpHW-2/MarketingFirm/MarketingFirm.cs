using System;
class MarketingFirm
{
    static void Main()
    {
        for (int i = 27560000; i < 27569999; i++)
        {

            Console.Write("Enter employee first name:");
            string firstName = Console.ReadLine();

            Console.Write("Enter employee last name:");
            string lastName = Console.ReadLine();

            Console.Write("Enter employee age:");
            int employeeAge = int.Parse(Console.ReadLine());

            Console.Write("Enter employee gender (male or female):");
            string employeeGender = Console.ReadLine();

            Console.Write("Enter employee ID number:");
            int idNumber = int.Parse(Console.ReadLine());

            int uniqueNumber = i;

            string gender = "female";
            if (employeeGender == "male")
            {
                gender = "male";
            }
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Employee info:");

            Console.WriteLine("First name:{0}", firstName);

            Console.WriteLine("Last name:{0}", lastName);

            Console.WriteLine("Age:{0}", employeeAge);

            Console.WriteLine("Gender:{0}", employeeGender);

            Console.WriteLine("ID number:{0}", idNumber);

            Console.WriteLine("Unique number:{0}", uniqueNumber);
            Console.WriteLine(new string('-', 40));
        }
    }
}

