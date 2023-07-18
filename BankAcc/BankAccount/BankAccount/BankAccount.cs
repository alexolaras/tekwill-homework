
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProj
{
    public class BankAccount
    {
        public DateTime CreationDate { set; get; }
        public Person Person { set; get; }
        public string AccountNumber { set; get; }
        public string Currency { get; set; }
        public string Pin { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public BankAccount(Person person, string accountNumber, string currency, string pin, double balance)
        {
            CreationDate = DateTime.Now;

            Person = person;
            AccountNumber = accountNumber;
            Currency = currency;
            Pin = pin;
            Balance = balance;
        }

        public double GetAccountBalance()
        {
            addTransaction("Balance check", 0);
            return Balance;

        }

        public void Deposit(double amount)
        {
            addTransaction("Deposit", amount);
            Balance += amount;
        }

        public void Withdrawl(double amount)
        {
            addTransaction("Balance withdrawl", amount);
            Balance -= amount;
        }
        public void ShowTransactions()
        {

                foreach (Transaction transaction in Transactions)
                {
                    Console.WriteLine(transaction.TransactionTime);
                    Console.WriteLine(transaction.TransactionTitle);
                    Console.WriteLine(transaction.Amount);
                    Console.WriteLine();
                }

        }
        public void addTransaction(string transactionTitle, double amount)
        {
            Transaction transaction = new Transaction(transactionTitle, amount);
            this.Transactions.Add(transaction);

        }



    }
}
