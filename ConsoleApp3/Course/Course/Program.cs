using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Course crs = new Course();
            Console.WriteLine("Enter course name: ");
            crs.CourseName = Console.ReadLine();
            Console.WriteLine("Enter course code: ");
            crs.CourseCode = Console.ReadLine();
            Console.WriteLine("Enter course credit: ");
            crs.CourseCredit = Convert.ToInt32(Console.ReadLine());

            crs.ShowCourseInfo();
        }
    }
    public class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }

        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }

        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }

        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name is " + courseName);
            Console.WriteLine("Course code is " + courseCode);
            Console.WriteLine("Course credit is " + courseCredit);

        }
    }
}
