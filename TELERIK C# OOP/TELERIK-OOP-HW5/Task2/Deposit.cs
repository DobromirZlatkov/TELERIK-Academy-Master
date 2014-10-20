using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, int interestRate)
            : base(customer, balance, interestRate)
        {
            
        }
        public override void Deposid(decimal money)
        {

            this.Balance += money;
        }
        public override void Withdraw(decimal money)
        {
            if (this.Balance > money)
            {
                this.Balance -= money;
            }
            else
            {
                throw new IndexOutOfRangeException("Not enough minerals");
            }
        }
        public override double CheckInterest(int months)
        {
            if (this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return months * this.InterestRate;
            }
        }
    }
}
