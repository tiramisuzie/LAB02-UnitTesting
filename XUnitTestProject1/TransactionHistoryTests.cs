using System;
using Xunit;

namespace LAB02_UnitTesting
{
    public class TransactionHistoryTests
    {
        [Fact]
        public void ShouldIntialHistory()
        {
            TransactionHistory transactionHistory = new TransactionHistory(1000);

            Assert.Equal("Starting balance is 1000\n", transactionHistory.history);
        }

        [Fact]
        public void ShouldAddDepositHistory()
        {
            TransactionHistory transactionHistory = new TransactionHistory(1000);
            transactionHistory.DepositTransaction(100, 1100);
            Assert.Equal("Starting balance is 1000\nDeposit: 100\nCurrent balance is 1100\n", transactionHistory.history);
        }

        [Fact]
        public void ShouldAddWithdrawHistory()
        {
            TransactionHistory transactionHistory = new TransactionHistory(1000);
            transactionHistory.WithdrawTransaction(100, 900);
            Assert.Equal("Starting balance is 1000\nWithdraw: 100\nCurrent balance is 900\n", transactionHistory.history);
        }

        [Fact]
        public void ShouldAddEndingBalance()
        {
            TransactionHistory transactionHistory = new TransactionHistory(1000);
            Assert.Equal("Starting balance is 1000\nEnding balance is 1000", transactionHistory.printOut());
        }
    }
}
