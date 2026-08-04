using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    
    internal class Course
    {
        public string CourseName { get; set; }
        public String CourseDescription { get; set; }

        public Grade courseGrade { get; set; }

        public Teacher CurrentTeacher { get; set; }

        public List<Assignment> assignments = new List<Assignment>();

        public List<Student> CurrentStudents { get; set; } = new List<Student>();


        public Grade CourseGrade { get; set; }
        public enum Grade
        {
            Undefined,
            A,
            B,
            C,
            D,
            F
        }

        public Course() { }

        public Course(string courseName, string courseDescription, Teacher currentTeacher)
        {
            CourseName = courseName;
            CourseDescription = courseDescription;
            CurrentTeacher = currentTeacher;
        }
    }
    
}
