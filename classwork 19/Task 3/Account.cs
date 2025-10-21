using System;

namespace Task_3
{
    internal abstract class Account
    {
        public int Number {  get; set; }
        public int Balance {  get; set; }

        public Account(int number, int balance)
        {
            Number = number;
            Balance = balance;
        }

        public abstract void Show();
    }

    internal class SavingsAccount : Account
    {
        public int InterestRate { get; set; }

        public SavingsAccount(int number, int balance, int interestRate) : base(number, balance)
        {
            InterestRate = interestRate;
        }

        public override void Show()
        {
            Console.WriteLine($"Number: {Number}. Balance: {Balance}. Interest Rate: {InterestRate}");
        }
    }

    internal class CheckingAccount : Account
    {
        public int TransactionFee { get; set; }

        public CheckingAccount(int number, int balance, int transactionFee) : base(number, balance)
        {
            TransactionFee = transactionFee;
        }

        public override void Show()
        {
            Console.WriteLine($"Number: {Number}. Balance: {Balance}. Transaction Fee: {TransactionFee}");
        }
    }
}
