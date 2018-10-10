using System;

namespace LAB02_UnitTesting
{
    class Program
    {
        public static double balance = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PseudoBank");
            UserInput();
        
        }

        public static void UserInput()
        {
            bool loop = true;
            Console.WriteLine("Please select from the following options.");
            Console.WriteLine("Press 1 to view balance");
            Console.WriteLine("Press 2 to withdraw money");
            Console.WriteLine("Press 3 to add money");
            Console.WriteLine("Press 4 to exit");

            while (loop)
            {
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
                else if (input == "4")
                {
                    loop = false;
                }
            }
       
        }

        public static double ViewBalance()
        {
            return balance;
        }

        public static void WithdrawMoney()
        {
            try
            {
                int amount = int.Parse(Console.ReadLine());
                balance -= amount;
            }
            catch
            {
                Console.WriteLine("Please enter valid amount");
            }
            finally
            {
                if (balance < 0)
                {
                    throw new Exception("whoops, you do not own that much money");
                }
            }

        }

        public static void AddMoney()
        {
            int amount = int.Parse(Console.ReadLine());
            balance += amount;
        }


    }
}
