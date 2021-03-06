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
                        Deposit();
                        break;
                    case "C":
                        ClearScreen();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }
        }

        private static void ClearScreen()
        {
            Console.Clear();
        }

        private static void Deposit()
        {
            Console.WriteLine("Inform the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            if(!ValidateAccount(accountNumber)) return;

            Console.WriteLine("Deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            accountList[accountNumber].Deposit(amount);
        }

        private static void Withdraw()
        {
            Console.WriteLine("Inform the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            if(!ValidateAccount(accountNumber)) return;

            Console.WriteLine("Amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            accountList[accountNumber].Withdraw(amount);
        }

        private static void Transfer()
        {
            Console.WriteLine("From account number: ");
            int fromAccount = int.Parse(Console.ReadLine());

             if(!ValidateAccount(fromAccount)) return;

            Console.WriteLine("To account number: ");
            int toAccount = int.Parse(Console.ReadLine());

             if(!ValidateAccount(toAccount)) return;

            Console.WriteLine("Value to transfer: ");
            double value = double.Parse(Console.ReadLine());

            accountList[fromAccount].Transfer(value, accountList[toAccount]);
        }

        private static void ListAccounts()
        {
            int count=0;
            Console.WriteLine("Listing Accounts");

            if(accountList.Count == 0)  {
                Console.WriteLine("No accounts registered.");
                return;
            }

            foreach (var account in accountList)
            {
                Console.WriteLine("#{0} - {1}", count, account.ToString());
                count++;
            }
        }

        private static void CreateAccount()
        {
            Console.WriteLine("Create new account");

            Console.WriteLine("Press 1 for Personal Account or 2 for Business Account: ");
            int accountTypeInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the client's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Insert the initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the credit: ");
            double credit = double.Parse(Console.ReadLine());

            Account account = new Account(name, balance, credit, (AccountType)accountTypeInput);

            accountList.Add(account);
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

        private static bool ValidateAccount(int accountIndex)
        {
            if (accountList.Count > accountIndex && accountIndex >= 0) return true;

            Console.WriteLine("Invalid Account!");
            return false;
        }
    }
}
