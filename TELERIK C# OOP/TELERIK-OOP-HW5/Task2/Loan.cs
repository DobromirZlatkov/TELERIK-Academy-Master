using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Loan : Account 
    {
        public Loan(Customer customer, decimal balance, int interestRate)
            : base(customer, balance, interestRate)
        {
            
        }        
        public override void Deposid(decimal deposit)
        {
            if (deposit < 0)
            {
                throw new ArgumentOutOfRangeException("You should deposit positive amounth");
            }
            else
            {
                this.Balance += deposit;
            }
        }

        public override double CheckInterest(int months)
        {
            if (months <= 3 && !Customer.IsCompany)
            {
                return 0;
            }
            else if (months <= 2 && Customer.IsCompany)
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
