
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProj
{
    public class BankAccount
    {
        private DateTime creationDate;
        private Person person;
        private string accountNumber;
        private string currency;
        private string pin;
        private double balance;
        public List<Transaction> transactions = new List<Transaction>();

        public BankAccount(DateTime creationDate, Person person, string accountNumber, string currency, string pin, double balance)
        {
            this.creationDate = DateTime.Now;
            this.person = new Person();
            this.accountNumber = accountNumber;
            this.currency = currency;
            this.pin = pin;
            this.balance = balance;
        }

        public double getAccountBalance()
        {
            Transaction transaction = new Transaction(DateTime.UtcNow, this, "Balance check", 0);
            transaction.addTransaction();
            return this.balance;

        }

        public void deposit(double amount)
        {
            Transaction transaction = new Transaction(DateTime.UtcNow, this, "Deposit", amount);
            transaction.addTransaction();
            this.balance += amount;
        }

        public void withdrawl(double amount)
        {
            Transaction transaction = new Transaction(DateTime.UtcNow, this, "Balance withdrawl", amount);
            transaction.addTransaction();
            this.balance -= amount;
        }
        public void showTransactions()
        {
            if (transactions != null)
            {
                foreach (Transaction transaction in transactions)
                {
                    Console.WriteLine(transaction.transactionTime);
                    Console.WriteLine(transaction.transactionTitle);
                    Console.WriteLine(transaction.amount);
                    Console.WriteLine();
                }
            }

        }



    }
}
