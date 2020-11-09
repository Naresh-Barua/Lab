using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Name = "X";
            stu.Id = "19-*****-1";
            stu.Department = "EEE";
            stu.Cgpa = 3.5f;

            Console.WriteLine("Student name is : " + stu.Name);
            Console.WriteLine("Student id is : " + stu.Id);
            Console.WriteLine("Student department is : " + stu.Department);
            Console.WriteLine("Student cgpa is : " + stu.Cgpa);

        }
    }
    public class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

    }
}