using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static List<Account> accountList = new List<Account>();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch(userOption)
                {
                    case "1":
                        ListAccounts();
                        break;
                    case "2":
                        CreateAccount();
                        break;
                    case "3":
                        Transfer();
                        break;
                    case "4":
                        Withdraw();
                        break;
                    case "5":
                        Deposit()
                        break;
                    case "C":
                        ClearScreen();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void ClearScreen()
        {
            throw new NotImplementedException();
        }

        private static void Deposit()
        {
            throw new NotImplementedException();
        }

        private static void Withdraw()
        {
            throw new NotImplementedException();
        }

        private static void Transfer()
        {
            throw new NotImplementedException();
        }

        private static void ListAccounts()
        {
            throw new NotImplementedException();
        }

        private static void CreateAccount()
        {
            throw new NotImplementedException();
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Online Bank at your service.");
            Console.WriteLine("Select the desired option:");

            Console.WriteLine("1 - List Accounts");
            Console.WriteLine("2 - Create new account");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("5 - Deposit");
            Console.WriteLine("C - Clear screen");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
