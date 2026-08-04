using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    internal class Assignment
    {
        public string AssignmentName { get; set; }
        public string AssignmentDescription { get; set; }

        public DateTime DueDate { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }

        public Grade AssignmentGrade { get; set; }


        public enum Grade
        {
            A,
            B,
            C,
            D,
            F
        }
        public Assignment(){ }

        public Assignment(string assignmentName, DateTime dueDate)
        {
            AssignmentName = assignmentName;
            DueDate = dueDate;
        }

        //public void setgrade(Grade grade)
        //{
        //    Assignment.Grade grade1 = grade;
        //}
    }
}
