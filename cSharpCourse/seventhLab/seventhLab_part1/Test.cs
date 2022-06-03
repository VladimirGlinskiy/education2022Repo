using System;
namespace seventhLab_part1
{
    public class Test
    {
        public static void Main()
        {
            decimal transferAmount = 10;

            BankAccount b1 = new BankAccount();
            b1.Populate(100);

            BankAccount b2 = new BankAccount();
            b2.Populate(100);

            Console.WriteLine("Перед переводом");
            Console.WriteLine("Первый счет. Тип: {0}, Номер: {1}, Баланс: {2} ", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("Второй счет. Тип: {0}, Номер: {1}, Баланс: {2} ", b2.Type(), b2.Number(), b2.Balance());
            b1.TransferForm(b2, transferAmount);
            Console.WriteLine("После перевода {0}", transferAmount);
            Console.WriteLine("Первый счет. Тип: {0}, Номер: {1}, Баланс: {2} ", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("Второй счет. Тип: {0}, Номер: {1}, Баланс: {2} ", b2.Type(), b2.Number(), b2.Balance());
            Console.ReadLine();
        }
    }
}
