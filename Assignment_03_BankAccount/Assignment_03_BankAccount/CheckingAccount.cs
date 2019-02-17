using System;
namespace Assignment_03_BankAccount
{
    public class CheckingAccount:BankAccount
    {
        private static double fee = 0.15;
        public CheckingAccount(string name, double amount):base(name,amount)
        {
            string checkAccountNo = base.GetAccountNumber() + "-" + "10";
            this.SetAccountNumber(checkAccountNo);
        }
        public override Boolean Withdraw(double amount)
        {
            Boolean withdrawComplete;

            if (GetBalance() - amount -fee>= 0)
            {
                withdrawComplete = true;
                SetBalance(GetBalance() - amount - fee);
            }
            else
            {
                withdrawComplete = false;
            }

            return withdrawComplete;
        }
    }
}
