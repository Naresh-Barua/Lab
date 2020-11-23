using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Savings : Accounts
    {
        //int maximumTransaction;

       
        public Savings(string name, int? accNo, double balance) : base(name, accNo, balance)
        {
            maximumTransaction = 100;
        }
        public Savings() 
        {
            maximumTransaction = 30;
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500 && TransactionNum <= maximumTransaction)
            {
                Balance -= amount;
                TransactionNum++;
            }
            else
            {
                Console.WriteLine("You can not withdraw. Amount reached least balance");
            }
        }
    }
}
