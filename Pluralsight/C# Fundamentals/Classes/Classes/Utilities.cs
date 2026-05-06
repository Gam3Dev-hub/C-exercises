using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Classes
{
    internal class Utilities
    {
        internal static int CalculateYearlyWage(int monthlySalary, int monthsWorked)
        {
            return monthlySalary * monthsWorked;
        }

        internal static double CalculateYearlyWage(double monthlySalary, int monthsWorked)
        {
            return monthlySalary * monthsWorked;
        }

        internal static double CalculateYearlyWage(double monthlySalary, int monthsWorked, int bonus = 0)
        {
            return monthlySalary * monthsWorked + bonus;
        }

        
    }
    public class Employee
    {
        private String firstName;
        private String lastName;
        private string email;
        private readonly byte age;

        public double hoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthday;

        public String FirstName {  get { return firstName; } set { firstName = value; } }
        public String LastName { get { return lastName; } set { lastName = value; } }
        public String Email { get { return email; } set { email = value; } }

       
        private String SetFirstName{  set { firstName = value; } }
        private string SetLastName { set { lastName = value; } }

        public Employee(String firstName, String lastName, String em, byte ageValue)
        {
            firstName = firstName;
            lastName = lastName;
            email = em;
            age = ageValue;
        }

        public void PerformWork()
        {
            hoursWorked++;
            WriteLine($"Employee {firstName} {LastName} has worked for {hoursWorked} hours");
        }

        //method overloading
        public void PerformWork(int numberOfHours)
        {
            hoursWorked += numberOfHours;
            WriteLine($"Employee {firstName} {LastName} has worked for {hoursWorked} hours");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = hourlyRate * hoursWorked;

            WriteLine($"Employee has worked for {hoursWorked} and received a wage of {wage}");

            if(resetHours)
                hoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            WriteLine($"first name: {firstName}");
            WriteLine($"last name: {lastName}");
            WriteLine($"email: {email}");
            WriteLine($"birthday: {birthday.ToShortDateString}");
        }





    }
}
