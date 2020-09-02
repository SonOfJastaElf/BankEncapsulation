using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Welcome.  How much will you deposit today?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);
            Console.WriteLine($"Thank you.  Your balance is now {account.GetBalance()}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("You're back!  How much do you need to withdraw?");
            var amountToWithdraw = double.Parse(Console.ReadLine());
            account.Withdraw(amountToWithdraw);
            Console.WriteLine($"Your account has {account.GetBalance()} remaining");
        }
    }
}
