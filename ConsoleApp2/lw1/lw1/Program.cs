using System;

namespace lw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine("Even Numbers from 1 to " + 50 + " are: ");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }

            }
        }
    }
}