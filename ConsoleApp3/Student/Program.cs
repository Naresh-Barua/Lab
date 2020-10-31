using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Name = "xyz";
            stu.Id = "19-*****-1";
            stu.Department = "CSE";

            Console.WriteLine("My name is : " + stu.Name);
            Console.WriteLine("My id is : " + stu.Id);
            Console.WriteLine("My department is : " + stu.Department);
            
        }
    }
    public class Student
    {
        private string name;
        private string id;
        private string department;

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


    }
}
