using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Console.WriteLine("Account name is :" + acc.AccName);
            Console.WriteLine("Account no is :" + acc.Acid);
            Console.WriteLine("Account balance is :" + acc.Balance);

            acc.Deposit(3000);
            acc.WithDraw(1000);
            Console.WriteLine("New balance  is :" + acc.Balance);
        }
    }
    public class Account
    {
        private string accName = "xyz";
        private string acid = "19_40332_1";
        private int balance = 0;

        public string AccName
        {
            get { return accName; }
           
        }
        public string Acid
        {
            get { return acid; }
           
        }

        public int Balance
        {
            get { return balance; }
            
        }

        public void Deposit(int value)
        {
            balance += value;
        }
        public void WithDraw(int value)
        {
            balance -= value;
        }
    }
}
