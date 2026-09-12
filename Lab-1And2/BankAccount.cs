using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1And2
{
    public enum AccountType
    {
        Current,
        Saving,
        Business,
        Generic
    }
    public class BankAccount
    {
        public static string BankName { get; private set; }
        public string AccountName { get; set; }

        public long AccountNumber { get; }

        //public decimal Balance { get; private set; }
        public decimal Balance { get; protected set; }

        public AccountType AccountType { get; set; } = AccountType.Generic;

        public bool IsActive { get; } = true;

        public List<string> TransactionHistory { get; } = new List<string>();

        // Static Constructor
        static BankAccount()
        {
            BankName = "Global Trust Bank";
        }

        // Instance Constructor
        public BankAccount(string accountName, long accountNumber)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            Balance = 0.0m;

            TransactionHistory.Add(
                $"Account created for {AccountName}. Account Number: {AccountNumber}"
            );
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += (decimal)amount;

            TransactionHistory.Add($"Deposited: {amount}");
        }
        public void Withdrawal(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if ((decimal)amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            Balance -= (decimal)amount;

            TransactionHistory.Add($"Withdrawn: {amount}");
        }
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine("===== Account Information =====");
            Console.WriteLine($"Bank Name: {BankName}");
            Console.WriteLine($"Account Name: {AccountName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Active: {IsActive}");

            Console.WriteLine("\nTransaction History:");

            foreach (string transaction in TransactionHistory)
            {
                Console.WriteLine($"- {transaction}");
            }
        }
    }
}

