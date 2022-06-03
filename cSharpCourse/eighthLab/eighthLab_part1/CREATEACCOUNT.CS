
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
        Write(acc2);
        Write(acc3);
        Write(acc4);
        Console.ReadLine();
    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number: {0}, balance: {1}, type: {2}", acc.Number(), acc.Balance(), acc.Type());
    }
}
