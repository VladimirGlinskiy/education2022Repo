using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vglinskii.aspNetMVC.Lab_1.WebMVCR1.Models
{
    public enum AccountType { 
    
        Checking, Deposit
    
    }

    public struct BankAccount {

        public long accNo;
        public decimal accBal; 
        public AccountType accType;

        public override string ToString()
        {
            string res = String.Format("Номер счета {0}, баланс {1}, тип {2}. Переопределенный стринг", accNo, accBal, accType); 
            return res; 
        }
    }

    public class StudyCSharp
    {


    }
}