using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02_UnitTesting
{
    public class TransactionHistory
    {
        public string history;
        private double currentBalance;
        public TransactionHistory(double balance)
        {
            history = "Starting balance is " + balance + "\n";
            currentBalance = balance;
        }

        public void DepositTransaction(double amount, double balance)
        {
            history += "Deposit: " + amount + "\n";
            history += "Current balance is " + balance + "\n";
            currentBalance = balance;
        }

        public void WithdrawTransaction(double amount, double balance)
        {
            history += "Withdraw: " + amount + "\n";
            history += "Current balance is " + balance + "\n";
            currentBalance = balance;
        }

        public string printOut()
        {
            return history += "Ending balance is " + currentBalance;
        }
    }
}
