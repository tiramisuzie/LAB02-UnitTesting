using System;

namespace LAB02_UnitTesting
{
    class Program
    {
        public static double balance = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PseudoBank");
        }

        public static void UserInput()
        {
            Console.WriteLine("Please select from the following options.");
            Console.WriteLine("Press 1 to view balance");
            Console.WriteLine("Press 2 to withdraw money");
            Console.WriteLine("Press 3 to add money");

            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine(ViewBalance());
            }
            else if (input == "2")
            {
                WithdrawMoney();
            }
            else if (input == "3")
            {
                AddMoney();
            }
        }

        public static double ViewBalance()
        {
            return balance;
        }

        public static void WithdrawMoney()
        {
            Console.ReadLine();
        }

        public static void AddMoney()
        {

        }
    }
}
