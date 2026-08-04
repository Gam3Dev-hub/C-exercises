using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    internal class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public List<Course> CoursesTaught { get; set; } = new List<Course>();

        public Teacher() { }

        public Teacher(string firstName, string lastName, DateTime dateOfEmployment)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfEmployment = dateOfEmployment;
        }
    }
}
