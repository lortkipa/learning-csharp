using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _number, _balance, _other;

            // savings account
            Console.WriteLine("----- Savings account -----");
            Console.Write("Account Number: "); _number = int.Parse(Console.ReadLine());
            Console.Write("Balance: "); _balance = int.Parse(Console.ReadLine());
            Console.Write("Interest Rate: "); _other = int.Parse(Console.ReadLine());
            Account savingsAcc = new SavingsAccount(_number, _balance, _other);
            savingsAcc.Show();

            // checking account
            Console.WriteLine("----- Checkings account -----");
            Console.Write("Account Number: "); _number = int.Parse(Console.ReadLine());
            Console.Write("Balance: "); _balance = int.Parse(Console.ReadLine());
            Console.Write("Transaction Fee: "); _other = int.Parse(Console.ReadLine());
            Account checkingAcc = new CheckingAccount(_number, _balance, _other);
            checkingAcc.Show();
        }
    }
}
