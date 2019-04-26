using System;
using Exercicio217.Entities.Exceptions;

namespace Exercicio217.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;

            Deposit(balance);
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new InsufficientAmountException(
                    "Deposit Error: Amount must be more than zero.");

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new InsufficientAmountException(
                    "Withdraw Error: Amount must be more than zero.");

            if (amount > WithdrawLimit)
                throw new WithdrawLimitException(
                    "Withdraw Error: Amount exceeds withdraw limit.");

            if (amount > Balance)
                throw new InsufficientBalanceException(
                    "Withdraw Error: Not enough balance.");

            Balance -= amount;
        }
    }
}
