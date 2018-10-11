using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02_UnitTesting
{
    public class Atm
    {
        public double balance;
        private TransactionHistory transactionHistory;

        public Atm(double amount)
        {
            balance = amount;
            transactionHistory = new TransactionHistory(balance);
        }

        public double ViewBalance()
        {
            return balance;
        }

        public void WithdrawMoney(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                transactionHistory.WithdrawTransaction(amount, balance);
            }
            else if (balance < amount)
            {
                throw new Exception("whoops, you do not own that much money");
            }
            else
            {
                throw new Exception("whoops, Invalid Input");
            }
        }

        public void AddMoney(double deposit)
        {
            if (deposit >= 0)
            {
                balance += deposit;
                transactionHistory.DepositTransaction(deposit, balance);
            }
            else
            {
                throw new Exception("whoops, Invalid Input");
            }
        }

        public string Summary()
        {
            return transactionHistory.printOut();
        }
    }
}
