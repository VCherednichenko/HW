using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.task6_1
{
    internal class BankAccount
    {
        private decimal balance;
        private readonly string accountNumber;

        internal BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        internal decimal Balance
        {
            get { return balance; }
        }

        internal string AccountNumber
        {
            get { return accountNumber; }
        }

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }

}
