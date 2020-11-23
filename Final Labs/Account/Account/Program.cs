using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acc1 = new Savings();
            Accounts acc2 = new Savings("X", 5000100, 14000);
            Accounts acc3 = new SpecialSavings("Y", 966544, 15000, 25);

            Accounts acc4 = new Fixed("X", 775844, 6000);

            Accounts acc5 = new Overdraft(2000);
            SpecialSavings s1 = new SpecialSavings(30);
          
            Overdraft od = new Overdraft("X", 557234, 11700, 5400);
        }
    }
}
