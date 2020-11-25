using System;

namespace Testinterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainCalc calc = new MainCalc();
            Console.WriteLine(" Sum = " + calc.sum(1, 1));
            Console.WriteLine(" Sub = " + calc.sub(10, 10));
            Console.WriteLine(" Multiplication = " + calc.multiplication(10, 10));
            Console.WriteLine(" Division = " + calc.division(25, 5));
            Console.WriteLine(" Power = " + calc.XtoY(55, 5));
        }
    }
}
