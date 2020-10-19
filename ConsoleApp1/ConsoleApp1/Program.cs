using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Naresh");

            int a = 3;
            int b = 3;
            int sum1,sum2;
            sum1= a + b;
            sum2 = a / b;
            Console.WriteLine("Sum= "+sum1);
            Console.WriteLine("Divide= " +sum2);


            int op1 = -5 + 8 * 6;
            Console.WriteLine("Op1=" + op1);
            int op2 = (55 + 9) % 9;
            Console.WriteLine("Op2=" + op2);
            int op3 = 20 + -3 * 5 / 8;
            Console.WriteLine("Op3=" + op3);
            int op4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Op4=" + op4);

            int c = 5;
            int d = 5;
            Console.WriteLine("Addition=" + (c + d));
            Console.WriteLine("Multiply=" + (c * d));
            Console.WriteLine("Subtract=" + (c - d));
            Console.WriteLine("Divide="   + (c / d));
            Console.WriteLine("Reminder=" + (c % d));

            double op6 = (((25.5 * 3.5) - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("Op6 is=" + op6);

            float width = 5.6f;
            float height = 8.5f;
            float area, perimeter;
            area = width*height;
            perimeter = 2*(width+height);
            Console.WriteLine("Area is=" +area);
            Console.WriteLine("Perimeter is=" +perimeter);
        }
    }
}
