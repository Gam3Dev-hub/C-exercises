using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritane
{
    internal class Parent
    {
        string FirstName {  get; set; }
        string LastName { get; set; }

        public Parent() 
        {
            Console.WriteLine("Parent class constructor");
        }

        public Parent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine($"Calling parent constructor with parameters: {FirstName} {LastName}");
        }
    }
}
