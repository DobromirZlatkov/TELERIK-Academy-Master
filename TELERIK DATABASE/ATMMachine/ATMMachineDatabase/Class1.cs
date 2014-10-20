namespace ATMMachineDatabase
{
    using System.Data.Entity;
    using System.Linq;

    using ATMMachine.Migrations;
    using ATMMachine.Data;
    using ATMMachine.Model;
    using System.Transactions;
    using System;

    public class Class1
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());

            var db = new ATMContext();

       //     LoadDataToCreditCard(db);

            int pin = 1002;
            int cardNumber = 10002;
            decimal moneyToWithdraw = 30m;

            using (db)
            {
                if (Withdraw(pin, cardNumber, moneyToWithdraw, db))
                {
                    Console.WriteLine("Money withdrawn");
                }
                else
                {
                    Console.WriteLine("Money withdrawn");
                }
            }
            Console.WriteLine("\nNew cards: ");
            PrintCards();

        }


        public static bool Withdraw(int pin, int cardNumber, decimal moneyToWithdraw, ATMContext db)
        { 
        
            bool success = true;
            int cardNumberToRecord = 0;
            using (var transactionScope = new TransactionScope(TransactionScopeOption.RequiresNew,new TransactionOptions()
                    {
                        IsolationLevel = IsolationLevel.RepeatableRead
                    }
                     )) 
            {
                var card = db.CardAccounts.FirstOrDefault(c => c.CardNumber == cardNumber);

                if (card == null || card.CardPIN != pin || card.CardCash < moneyToWithdraw)
                {
                    success = false;
                }
                else
                {
                    card.CardCash -= moneyToWithdraw;
                    cardNumberToRecord = card.CardNumber;
                    transactionScope.Complete();
                }
            
            }

            if (success)
            {
                RecordWithdraw(cardNumber, moneyToWithdraw, db);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void RecordWithdraw(int cardNumber, decimal moneyToWithdraw, ATMContext db)
        {
            using (var transactionScope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions()
            {
                IsolationLevel = IsolationLevel.RepeatableRead
            }
                ))
            {
                db.TransactionsHistory.Add(new TransactionHistory()
                {
                    TransactionDate = DateTime.Now,
                    Amounth = moneyToWithdraw,
                    CardNumber = cardNumber
                });
                transactionScope.Complete();
            }
        }

        private static void LoadDataToCreditCard(ATMContext db)
        {
            for (int i = 0; i < 10; i++)
            {
                db.CardAccounts.Add(new CardAccount
                {
                    CardNumber = 10000 + i,
                    CardPIN = 1000 + i,
                    CardCash = 200 + i
                });
            }
            db.SaveChanges();
        }

        public static void PrintCards()
        {
            using (ATMContext db = new ATMContext())
            {
                foreach (var item in db.CardAccounts)
                {
                    Console.WriteLine("ID:{0}, Monies: {1}", item.CardAccountId, item.CardCash);
                }
            }
        }
    }
}
