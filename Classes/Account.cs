using System;

namespace Bank
{
    public class Account
    {
        private string Name { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private AccountType AccountType { get; set; }

        public Account(string name, double balance, double credit, AccountType accountType)
        {
            this.Name = name;
            this.Balance = balance;
            this.Credit = credit;
            this.AccountType = accountType;
            
        }

        public bool Withdraw(double value)
        {
            if(this.Balance - value < (this.Credit *-1))
            {
                Console.WriteLine("Insufficient Balance!");
                return false;
            }

            this.Balance -= value;

            Console.WriteLine("Current balance from {0}'s account is {1}", this.Name, this.Balance);
            return true;
        }

        public void Deposit(double value)
        {
            this.Balance += value;

            Console.WriteLine("Current balance from {0}'s account is {1}", this.Name, this.Balance);
        }

        public bool Transfer(double value, Account toAccount)
        {
            if (this.Withdraw(value))
            {
                toAccount.Deposit(value);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string output = "";
            output += "Account Type " + this.AccountType + "| ";
            output += "Name" + this.Name + "| ";
            output += "Balance" + this.Balance + "| ";
            output += "Credit" + this.Credit + "| ";
            return output;
        }
    }

}