
class BankAccount
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;

    private static long nextNumber = 123;

    public BankAccount() {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0;
    }

    public BankAccount (AccountType aType){
        accNo = NextNumber();
        accType = accType;
        accBal = 0;
    }

    public BankAccount(decimal aBal) {
        accBal = aBal;
        accType = AccountType.Checking;
        accNo = NextNumber();
    }

    public BankAccount(AccountType aType, decimal aBal) {
        accType = aType;
        accBal = aBal;
        accNo = NextNumber();
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
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
