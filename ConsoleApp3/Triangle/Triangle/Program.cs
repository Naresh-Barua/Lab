using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            Console.WriteLine("Enter value x: ");
            tri.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value y: ");
            tri.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value z: ");
            tri.Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x is : " + tri.X);
            Console.WriteLine("y is : " + tri.Y);
            Console.WriteLine("z is : " + tri.Z);
            tri.TestTriangle();
        }
    }
    public class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public void TestTriangle()
        {
            if (x == y || x == z || y == z)
            {
                Console.WriteLine("Checked triangle is isosceles");
            }
            else if (x == y && x == z)
            {
                Console.WriteLine("Checked triangle is equilateral");
            }
            else
            {
                Console.WriteLine("Checked triangle is scalene");
            }
        }
    }
}
