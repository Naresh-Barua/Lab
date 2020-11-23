using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    abstract class Accounts
    {
        abstract public void Withdraw(double amount);
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int? accNo;

        protected Accounts(string name, int? accNo, double balance)
        {
            this.name = name;
            this.accNo = accNo;
            this.Balance = balance;
        }

        protected double? Balance
        { get; set; }

        protected int TransactionNum
        { get; set; }
        protected int maximumTransaction
        { get; set; }


        public int? AccNo
        {
            get { return (int)accNo; }
            set { accNo = value; }
        }


        public void Account()
        {
            this.name = null;
            this.Balance = null;
            this.accNo = null;
        }

        protected void Account(string name, int? accNo, object balance)
        {
            this.name = name;
            this.accNo = accNo;
            this.Balance = Balance;
        }

       
    }
}