using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisGenAccount.Entities.Exceptions;

namespace SisGenAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double withdrawLimit) 
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance == 0) 
            {
                throw new DomainException("Not enough balance.");
            }
            if (amount > WithdrawLimit || amount < Balance)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            Balance -= amount;
        }
    }
}
