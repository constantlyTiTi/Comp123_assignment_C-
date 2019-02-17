using System;

namespace Assignment_03_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkAccount1 = new CheckingAccount
                                            ("Benjamin Franklin", 1000);
            printInfor(checkAccount1);


            SavingAccount savingAccount1 = new SavingAccount
                                            ("William Shakespeare", 400);
            printInfor(savingAccount1);


            SavingAccount savingAccount2 = new SavingAccount
                                            (savingAccount1, 5);
            printInfor(savingAccount2);
           

            CheckingAccount checkAccount2 = new CheckingAccount
                                            ("Isaac Newton", 1000);
            printInfor(checkAccount2);


            void printInfor(BankAccount bankAccount)
            {
                Console.WriteLine("Account Number {0} belongs to {1}",
                                  bankAccount.GetAccountNumber(), bankAccount.GetOwner());
                Console.WriteLine("Initial balance ={0:c2}", bankAccount.GetBalance());
                bankAccount.Deposit(500);
                Console.WriteLine("After deposit $500, balance = {0:c2}", bankAccount.GetBalance());
                if (bankAccount.Withdraw(1000) == true)
                {
                    Console.WriteLine("After withdrawal of $1000.00, balance = {0:c2}"
                                      , bankAccount.GetBalance());
                }
                else 
                {
                    Console.WriteLine("Insufficient funds to withdraw $1000.00," +
                                      " balance = {0:c2}", bankAccount.GetBalance());
                }
                if(bankAccount.GetType().Equals(typeof (SavingAccount))){
                    ((SavingAccount)bankAccount).PostInterest();
                    Console.WriteLine("After Monthly interest has been posted, " +
                                      "balance = {0:c2}", bankAccount.GetBalance());
                }
                Console.WriteLine();

            }

        }
    }
}
