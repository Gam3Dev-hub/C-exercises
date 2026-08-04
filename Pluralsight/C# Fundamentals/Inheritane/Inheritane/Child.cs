using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritane
{
    internal class Child : Parent, Interfaces.ITest
    {
        string NickName { get; set; }
        public Child():base()
        {
            Console.WriteLine("Child class constructor");
        }
        
        public Child(string firstName, string lastName) : base(firstName, lastName)
        {
            
            Console.WriteLine($"Calling child constructor with parameters: {firstName} {lastName}");
        }
    }
}
