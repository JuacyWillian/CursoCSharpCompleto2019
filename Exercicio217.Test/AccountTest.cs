using System;
using System.Reflection;
using NUnit;
using NUnit.Framework;

using Exercicio217.Entities;
using Exercicio217.Entities.Exceptions;

namespace Exercicio217.Test
{
    [TestFixture]
    public class AccountTest
    {
        Account Acc;

        [SetUp]
        public void Init()
        {
            Acc = new Account(1001, "Juacy Willian", 300.00, 600.00);
        }

        [Test]
        public void CreateAccount()
        {
            Assert.IsInstanceOf<Account>(Acc);
        }

        [Test]
        public void ErrorInAccountCreation()
        {
            var e = Assert.Throws<InsufficientAmountException>(
                () => new Account(1001, "Joao Mario", -200, 1000));
            Assert.AreEqual(e.Message, "Deposit Error: Amount must be more than zero.");
        }

        [Test]
        public void DepositNegativeAmount()
        {
            var e = Assert.Throws<InsufficientAmountException>(()=> Acc.Deposit(-200));
            Assert.AreEqual(e.Message, "Deposit Error: Amount must be more than zero.");
        }

        [Test]
        public void DepositAmount()
        {
            Acc.Deposit(700.00);
            Assert.AreEqual(Acc.Balance, 1000.00);
        }

        [Test]
        public void WithdrawNegativeAmount()
        {
            var e = Assert.Throws<InsufficientAmountException>(() => Acc.Withdraw(-200));
            Assert.AreEqual(e.Message, "Withdraw Error: Amount must be more than zero.");
        }

        [Test]
        public void WithdrawExceedLimit()
        {
            var e = Assert.Throws<WithdrawLimitException>(() => Acc.Withdraw(800));
            Assert.AreEqual(e.Message, "Withdraw Error: Amount exceeds withdraw limit.");
        }

        [Test]
        public void WithdrawExceedAccountBalance()
        {
            var e = Assert.Throws<InsufficientBalanceException>(() => Acc.Withdraw(301));
            Assert.AreEqual(e.Message, "Withdraw Error: Not enough balance.");
        }

        [Test]
        public void WithdrawSuccess()
        {
            Acc.Withdraw(200);
            Assert.AreEqual(Acc.Balance, 100.00);
        }
    }
}
