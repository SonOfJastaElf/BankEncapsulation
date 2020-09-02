using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much will you deposit today?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);
            Console.WriteLine($"Thank you.  Your balance is now {account.GetBalance()}");
        }
    }
}
