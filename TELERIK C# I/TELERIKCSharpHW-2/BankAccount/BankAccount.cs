using System;
class BankAccount
{
    static void Main()
    {
        Console.WriteLine("CREATE BANK ACCOUNT");
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter second name: ");
        string secondName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter bank name: ");
        string bankName = Console.ReadLine();

        Console.Write("Enter IBAN: ");
        string iBAN = Console.ReadLine();

        Console.Write("Enter BIC code: ");
        int bicCode = int.Parse(Console.ReadLine());


        ulong[] creditCardNumber = new ulong[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter creditcard-{0} number: ",i);
            ulong papaz = ulong.Parse(Console.ReadLine());
            creditCardNumber[i] = papaz;
        }
        Console.WriteLine(new string('-',40));

        Console.WriteLine("Your first name is: {0}", firstName);

        Console.WriteLine("Your second name is: {0}", secondName);

        Console.WriteLine("Your last name is: {0}", lastName);

        Console.WriteLine("Your bank name is: {0}", bankName);

        Console.WriteLine("Your IBAN : {0}", iBAN);

        for (int i = 0; i < creditCardNumber.Length; i++)
        {
            Console.WriteLine("Your creditcard-{0} number is:{1} ",i , creditCardNumber[i]);
        }
       

    }
}
