using System.Collections;



    public class Bank
    {

    private Bank() { }

    public static long CreateAccount()
        {
            BankAccount bankAccount = new BankAccount();
            long accNo = bankAccount.Number();
            accounts[accNo] = bankAccount;
            return accNo;
        }

    public static long CreateAccount(AccountType accountType, decimal accountBalance)
    {
        BankAccount bankAccount = new BankAccount(accountType, accountBalance);
        long accNo = bankAccount.Number();
        accounts[accNo] = bankAccount;
        return accNo;
    }

    public static long CreateAccount(AccountType accountType)
    {
        BankAccount bankAccount = new BankAccount(accountType);
        long accNo = bankAccount.Number();
        accounts[accNo] = bankAccount;
        return accNo;
    }

    public static long CreateAccount(decimal accountBalance)
    {
        BankAccount bankAccount = new BankAccount(accountBalance);
        long accNo = bankAccount.Number();
        accounts[accNo] = bankAccount;
        return accNo;
    }

    private static Hashtable accounts = new Hashtable();

    public static bool CloseAccount(long accNumber) {
        BankAccount bankAccount = (BankAccount)accounts[accNumber];
        if (bankAccount != null)
        {
            accounts.Remove(accNumber);
            bankAccount.Dispose();
            return true;

        }

        else {
            return false;
        }
    }



    public static BankAccount GetAccout(long accNumber) {

        return (BankAccount)accounts[accNumber];

    }



}
