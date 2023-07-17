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
        public DateTime transactionTime;
        public BankAccount account;
        public string transactionTitle;
        public double amount;

        public Transaction(DateTime transactionTime, BankAccount account, string transactionTitle, double amount)
        {
            this.transactionTime = transactionTime;
            this.account = account;
            this.transactionTitle = transactionTitle;
            this.amount = amount;
        }

        public void addTransaction()
        {
            if (account.transactions != null)
            {
                Transaction transaction = new Transaction(DateTime.UtcNow, account, transactionTitle, amount);
                account.transactions.Add(transaction);
            }

        }


    }
}
