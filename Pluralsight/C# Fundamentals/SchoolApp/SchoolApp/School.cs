using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    internal class School
    {
        public String Name { get; set; }

        public String Address { get; set; }
        public School() { }

        public School(string name) 
        {
            Name = name;
        }

        public School(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<Course> courses = new List<Course>();
        public List<Assignment> assignments = new List<Assignment>();
    }
}
