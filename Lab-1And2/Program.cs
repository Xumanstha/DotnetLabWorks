using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1And2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Suman Shrestha",123456);
            bankAccount.Deposit(2345);
            bankAccount.Withdrawal(123);
            bankAccount.DisplayAccountInfo();

            SavingsAccount savingsAccount = new SavingsAccount(bankAccount.AccountName, bankAccount.AccountNumber);
            savingsAccount.Deposit(200020);
            savingsAccount.Withdrawal(10101);
            savingsAccount.ApplyInterest();
            savingsAccount.DisplayAccountInfo();
        }
    }
}
