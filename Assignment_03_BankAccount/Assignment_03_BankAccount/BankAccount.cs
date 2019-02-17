using System;
namespace Assignment_03_BankAccount
{
    public class BankAccount
    {
        private double balance;
        private string owner;
        private static string accountNumber;
        protected static int numberOfAccounts = 10000;


        public BankAccount()
        {

            string newAccountNumber = (++numberOfAccounts).ToString();
            SetAccountNumber( newAccountNumber);

        }
        public BankAccount(string name,double amount):this()
        {
            SetBalance(amount);
            owner = name;

        }
        public BankAccount(BankAccount oldAccount,double amount)
        {
            this.owner = oldAccount.GetOwner();
            this.balance = amount;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public virtual Boolean Withdraw(double amount)
        {
            Boolean withdrawComplete;

            if (balance-amount>=0)
            {
                withdrawComplete = true;
            }
            else
            {
                withdrawComplete = false;
            }

            return withdrawComplete;
        }
        public double GetBalance()
        {
            return balance;
        }
        public string GetOwner()
        {
            return owner;
        }
        public virtual string GetAccountNumber()
        {
            return accountNumber;
        }
        public void SetBalance(double amount)
        {
             balance = amount;
        }
        public void SetAccountNumber(string newAccountNumber)
        {
            accountNumber = newAccountNumber;


        }
    }
}
