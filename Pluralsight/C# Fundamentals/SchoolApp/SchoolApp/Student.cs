using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        //public Dictionary  <Course, List<Assignment>> courseAssignmentGrades = new Dictionary<Course, List<Assignment>>();

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public Student() { }
        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
