
using BankAccountProj;

class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Andrei", "andrei@gmail.com", "Calea basarabiei 27", "079842742", "2857420929571");

        BankAccount bankAccount = new BankAccount(DateTime.UtcNow, person, "3423423423665865", "mdl", "1234", 0);

        bankAccount.deposit(1000);
        bankAccount.withdrawl(200);


        bankAccount.showTransactions();
        Console.WriteLine("Soldul curent: {0}", bankAccount.getAccountBalance());
    }
}