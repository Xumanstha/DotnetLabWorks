using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1And2
{
    public class SavingsAccount : BankAccount
    {
        public const double InterestRate = 0.04;

        public SavingsAccount(string accountName, long accountNumber)
            : base(accountName, accountNumber)
        {
        }

        public void ApplyInterest()
        {
            double interest = (double)Balance * InterestRate;

            base.Deposit(interest);
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();

            Console.WriteLine($"Interest Rate: {InterestRate * 100}%");
        }
    }
}
