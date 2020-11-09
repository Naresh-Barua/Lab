using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            Console.WriteLine("Account name is :" + ac.AccName);
            Console.WriteLine("Account no is :" + ac.Acid);
            Console.WriteLine("Balance is :" + ac.Balance);

            ac.Deposit(5000);
            ac.WithDraw(2000);
            Console.WriteLine("New balance  is :" + ac.Balance);
        }
    }
    public class Account
    {
        private string accName = "X";
        private string acid = "19*****1";
        private int balance = 0;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void WithDraw(int amount)
        {
            balance -= amount;
        }
    }
}