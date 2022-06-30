using System.Collections;

class BankAccount 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    private Queue tranQueue = new Queue();

    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType = accType;
        accBal = 0;
    }

    public BankAccount(decimal aBal)
    {
        accBal = aBal;
        accType = AccountType.Checking;
        accNo = NextNumber();
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accType = aType;
        accBal = aBal;
        accNo = NextNumber();
    }

    private static long nextNumber;

    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
            BankTransaction bTransaction = new BankTransaction(-amount);
            tranQueue.Enqueue(bTransaction);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction bTransaction = new BankTransaction(amount);
        tranQueue.Enqueue(bTransaction);
        return accBal;
    }

    public Queue Transactions() {
        return tranQueue;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextNumber++;
    }
}
