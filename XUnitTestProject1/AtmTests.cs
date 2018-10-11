using System;
using Xunit;

namespace LAB02_UnitTesting
{
    public class AtmTests
    {
        [Fact]
        public void ShouldReturnCorrectBalance()
        {
            double expected = 1000;

            Atm atm = new Atm(expected);

            Assert.Equal(expected, atm.ViewBalance());
        }

        [Fact]
        public void ShouldReturnZeroBalance()
        {
            double expected = 0;

            Atm atm = new Atm(0);

            Assert.Equal(expected, atm.ViewBalance());
        }

        [Fact]
        public void ShouldWithdraw()
        {
            double balance = 1000;
            double expectedBalance = 500;
            Atm atm = new Atm(balance);

            atm.WithdrawMoney(500);

            Assert.Equal(expectedBalance, atm.ViewBalance());
        }

        [Fact]
        public void ShouldThrowIfWithdrawOverCurrentBalance()
        {
            double balance = 400;
            Atm atm = new Atm(balance);
            
            Assert.Throws<Exception>(() => atm.WithdrawMoney(500));
        }

        [Fact]
        public void ShouldAddMoney()
        {
            double balance = 1000;
            double expectedBalance = 1500;
            Atm atm = new Atm(balance);

            atm.AddMoney(500);

            Assert.Equal(expectedBalance, atm.ViewBalance());
        }

        [Fact]
        public void ShouldNotHandleNegativeMoney()
        {
            double balance = 1000;
            Atm atm = new Atm(balance);

            Assert.Throws<Exception>(() => atm.AddMoney(-500));
        }

        [Fact]
        public void ShouldReturnTransactionSummary()
        {
            double balance = 1000;
            Atm atm = new Atm(balance);

            Assert.Equal("Starting balance is 1000\nEnding balance is 1000", atm.Summary());
        }

        [Fact]
        public void ShouldReturnTransactionSummary2()
        {
            double balance = 1000;
            Atm atm = new Atm(balance);
            atm.AddMoney(100);
            Assert.Equal("Starting balance is 1000\nDeposit: 100\nCurrent balance is 1100\nEnding balance is 1100", atm.Summary());
        }
    }
}
