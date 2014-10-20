using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers =
            {
                new Customer("1","Ivan","Sofia","123456",false),
                
                new Customer("2","IvanOOD","Varna","123456",true),
                
                new Customer("3","Mariika","Sofia","123456",false),
                
                new Customer("4","MariikaOOD","Sofia","123456",true),
            };

            List<Account> accounts = new List<Account>();
            accounts.Add(new Deposit(customers[0], 4321, 1234));
            accounts.Add(new Loan(customers[1], 4321, 1234));
            accounts.Add(new Mortgage(customers[2], 4321, 1234));



            foreach (var account in accounts)
            {
                Console.WriteLine("Acc interest = " + account.CheckInterest(2));                                                
            }
            foreach (var account in accounts)
            {
                account.Deposid(500);
            }
            foreach (var account in accounts)
            {
                account.Withdraw(100);
            }
            foreach (var account in accounts)
            {
                Console.WriteLine(account.Balance);
            }

        }
    }
}
