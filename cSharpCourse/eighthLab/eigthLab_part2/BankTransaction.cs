using System;



public class BankTransaction
    {

    public BankTransaction(decimal tranAmount) {
        when = DateTime.Now;
        amount = tranAmount;
    }

    private readonly decimal amount;
    private readonly DateTime when;

    public decimal Amount() {
        return amount;
    }

    public DateTime When()
    {
        return when;
    }
}

