using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private int interestRate;

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public int InterestRate
        {
            get { return this.interestRate; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative");
                }
                this.interestRate = value;
            }
        }

        public Account(Customer customer, decimal balance, int interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
       
        public virtual double CheckInterest(int months)
        {
            return months * InterestRate;
        }
        public virtual void Deposid(decimal money)
        { }
        public virtual void Withdraw(decimal money)
        { }
    }
}
