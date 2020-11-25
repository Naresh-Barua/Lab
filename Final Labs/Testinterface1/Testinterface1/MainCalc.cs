using System;
using System.Collections.Generic;
using System.Text;

namespace Testinterface1
{
    class MainCalc : BasicCalculator, ScientificCalculator
    {
        int result;
        public int sum(int x, int y)
        {
            
            //Console.WriteLine("sum: " + sum(10, 10));
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int multiplication(int x, int y)
        {
            return x * y;
        }
        public int division(int x, int y)
        {
            return x / y;
        }
        public int XtoY(int x, int y)
        {
            while (y != 0)
            {
                result *= x;
                --y;
            }
            return result;
        }
    }
}