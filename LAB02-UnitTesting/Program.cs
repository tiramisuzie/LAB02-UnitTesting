using System;

namespace LAB02_UnitTesting
{
    class Program
    {
        public static Atm atm = new Atm(1000);

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PseudoBank");
            UserInput();
            Console.WriteLine("Thank you");
        }

        public static void UserInput()
        {
            bool loop = true;
            
            while (loop)
            {
                Console.WriteLine("Please select from the following options.");
                Console.WriteLine("Press 1 to view balance");
                Console.WriteLine("Press 2 to withdraw money");
                Console.WriteLine("Press 3 to add money");
                Console.WriteLine("Press 4 to exit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine(atm.ViewBalance());
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
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            Console.WriteLine(atm.Summary());
        }
        
        public static void WithdrawMoney()
        {
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please enter the amount you want to withdraw");
                try
                {
                    double amount = double.Parse(Console.ReadLine());
                    atm.WithdrawMoney(amount);
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid amount");
                }
                finally
                {
                    Console.WriteLine("Your Current Balance is " + atm.ViewBalance());
                }
            }
        }

        public static void AddMoney()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter the amount you want to deposit");
                try
                {
                    double amount = double.Parse(Console.ReadLine());
                    atm.AddMoney(amount);
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid amount");
                }
                finally
                {
                    Console.WriteLine("Your Current Balance is " + atm.ViewBalance());
                }
            }
            
        }


    }
}
