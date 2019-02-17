using System;
namespace Assignment_03_BankAccount
{
    public class SavingAccount:BankAccount
    {
        private const double rate = 0.025;
        private int savingsNumber=0;
        private string accountNumber;

        public SavingAccount(string name, double amount):base(name,amount)
        {
            accountNumber = base.GetAccountNumber() + "-" + savingsNumber.ToString();
        }
        public SavingAccount(SavingAccount oldAccount,double amount):base(oldAccount,amount)
        {
            this.savingsNumber=oldAccount.savingsNumber+1;
            this.accountNumber = base.GetAccountNumber() + "-" + this.savingsNumber;

        }
        public void PostInterest()
        {
            SetBalance( GetBalance() * (1 + rate/12));
        }
        public override string GetAccountNumber()
        {

            return accountNumber;
        }
    } 
}
