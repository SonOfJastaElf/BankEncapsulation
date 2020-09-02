using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        
        private double balance = 0;
        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public void Deposit(double depositAmount)
        {
           balance = depositAmount;
        }

        public string GetBalance()
        {
            return $"${balance}";
        }

        public void Withdraw(double withdrawAmount)
        {
            balance -= withdrawAmount;
        }
    }
}
