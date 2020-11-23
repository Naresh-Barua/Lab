using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Fixed:Accounts
    {
        DateTime tenure_year = new DateTime(2020, 12, 16);
        public Fixed(string name, int? accNo, double balance) : base (name, accNo, balance)
        {
            this.Name = name;
            this.AccNo = accNo;
            this.Balance = balance;
        }
        public override void Withdraw(double amount)
        {
            if (tenure_year < DateTime.Today && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Transaction denied!");
            }
        }
    }
}
