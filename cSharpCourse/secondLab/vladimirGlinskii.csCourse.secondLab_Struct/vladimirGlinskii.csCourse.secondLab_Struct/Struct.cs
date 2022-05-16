using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladimirGlinskii.csCourse.secondLab_Struct
{
    public enum AccountType { Checking, Deposit }
    public struct BankAccount
    {
        public long accNumber;
        public decimal accBalance; 
        public AccountType accType;


    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBalance = (decimal)3200.00;
            goldAccount.accNumber = 123;

            Console.WriteLine("***Account Summary***");
            Console.WriteLine("Account Number {0}", goldAccount.accNumber);
            Console.WriteLine("Account Type {0}", goldAccount.accType);
            Console.WriteLine("Account Balance {0}", goldAccount.accBalance);

            Console.ReadLine(); 
        }
    }
}
