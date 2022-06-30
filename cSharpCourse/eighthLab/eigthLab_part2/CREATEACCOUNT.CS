
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {

        BankAccount acc1 = new BankAccount();
        BankAccount acc2 = new BankAccount(AccountType.Deposit);
        BankAccount acc3 = new BankAccount(100);
        BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);

        Write(acc1);
        acc1.Deposit(1000);
        Write(acc1);
        acc1.Withdraw(100);
        Write(acc1);

        Write(acc2);
        acc2.Deposit(666);
        Write(acc2);
        acc2.Withdraw(555);
        Write(acc2);

        Write(acc3);
        acc3.Deposit(50);
        Write(acc3);
        acc3.Withdraw(10);
        Write(acc3);

        Write(acc4);
        acc4.Deposit(2000);
        Write(acc4);
        acc4.Withdraw(2000);
        Write(acc4);

        Console.ReadLine(); 
    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transactions:");
        foreach (BankTransaction transaction in acc.Transactions()) {
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", transaction.When(), transaction.Amount());
            
        }
        Console.WriteLine();
    }
}
