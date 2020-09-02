using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for choosing National Hendersonian Bank.  To creat an account, we'll need to know some things about you, including your phne number:");
            var newMember = new PersonalInfo
            {
                FirstName = "Allen",
                LastName = "Boyd",
                StreetAddress = "5539 Starboard Ct",
                Address2 = "N/A",
                City = "Fairfax",
                State  ="VA",
                Zip = 22032
            };
            newMember.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Got it!  Again, that number is {newMember.NumberFormatted}");
            Console.WriteLine("----------------------------------------");
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
