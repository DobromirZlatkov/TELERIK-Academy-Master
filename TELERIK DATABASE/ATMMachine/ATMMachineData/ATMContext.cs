using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMMachine.Model;

namespace ATMMachine.Data
{
    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("ATMMachine")
        {

        }

        public DbSet<CardAccount> CardAccounts { get; set; }
        public DbSet<TransactionHistory> TransactionsHistory { get; set; }
    }
}