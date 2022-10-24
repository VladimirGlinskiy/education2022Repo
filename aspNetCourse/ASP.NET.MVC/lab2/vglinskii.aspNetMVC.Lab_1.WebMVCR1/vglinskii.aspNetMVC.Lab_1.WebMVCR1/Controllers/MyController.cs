using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vglinskii.aspNetMVC.Lab_1.WebMVCR1.Models;

namespace vglinskii.aspNetMVC.Lab_1.WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        public string Index()
         {
            string res = ExecStruct();
            return res;
         }


        public string Start() { 
        
        int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        
        }

        public string ExeEnum() {

            AccountType goldAccount; 
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);

            string res = res1 + "<p>" + res2;  
            return res;

        }

        public string ExecStruct() {
            BankAccount goldBankAccount;

            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accNo = 123;

            //string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType);
            // string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);
            string res = $"Номер счета {goldBankAccount.accNo}, баланс {goldBankAccount.accBal}, тип {goldBankAccount.accType}, интерполяция";

            return res; 
        }

    }
}