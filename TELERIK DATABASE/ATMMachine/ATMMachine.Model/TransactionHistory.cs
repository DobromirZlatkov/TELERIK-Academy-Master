namespace ATMMachine.Model
{
    using System;

    public class TransactionHistory
    {
        public int TransactionHistoryId { get; set; }

        public int CardNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Amounth { get; set; }
    }
}
