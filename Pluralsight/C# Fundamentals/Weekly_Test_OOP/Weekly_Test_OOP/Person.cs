using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly_Test_OOP
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        protected internal void Speak()
        {
            WriteLine($"Hello, my name is {FirstName} {LastName}");
        }
    }
}
