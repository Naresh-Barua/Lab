using System;

namespace lw4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0; ;
            int sumOdd = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;
            }

            Console.WriteLine("The sum of even is : " + sumEven);
            Console.WriteLine("The sum of odd is : " + sumOdd);
        }
    }
}
