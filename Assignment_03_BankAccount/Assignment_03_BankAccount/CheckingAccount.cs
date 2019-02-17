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
        #region FirstWay to do Widthdraw
        //public override Boolean Withdraw(double amount)
        //{
        //    Boolean withdrawComplete;

        //    if (GetBalance() - amount - fee >= 0)
        //    {
        //        withdrawComplete = true;
        //        SetBalance(GetBalance() - amount - fee);
        //    }
        //    else
        //    {
        //        withdrawComplete = false;
        //    }

        //    return withdrawComplete;
        //}
        #endregion
        #region secondWay to do Widthdraw
        public override Boolean Withdraw(double amount)
        {
            double restBalance;
            restBalance = this.GetBalance() - amount - fee;
            SetBalance(restBalance);
            return base.Withdraw(restBalance);
        }
        #endregion
    }
}
