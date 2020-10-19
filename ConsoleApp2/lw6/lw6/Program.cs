using System;

namespace lw6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,digit;
            int factor = 1;
            Console.WriteLine("Enter number: ");

            digit = Convert.ToInt32(Console.ReadLine());
            for (i =1;i<=digit;i++)
            {
                factor = factor * i;

            }
            Console.WriteLine("Factorial is:" + factor);

        }
    }
}
