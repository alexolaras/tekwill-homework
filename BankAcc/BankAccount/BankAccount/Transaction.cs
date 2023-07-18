using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankAccountProj
{
    public class Transaction
    {
        public DateTime TransactionTime { get; set; }
        //public BankAccount Account { get; set; }
        public string TransactionTitle { get; set; }
        public double Amount { get; set; }


        public Transaction(string transactionTitle, double amount)
        {
            TransactionTime = DateTime.UtcNow;

            //Account = account;
            TransactionTitle = transactionTitle;
            Amount = amount;
        }




    }
}
