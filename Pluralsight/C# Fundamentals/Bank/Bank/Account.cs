using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    internal class Account : Bank
    {
      public  string FirstName { get; private set; }
      public  string LastName { get; private set; }
      public string Email { get; private set; }
      private int AccountNumber { get; set; }
      private double Balance { get; set; }

        private Account() 
        {
            Accounts++;
        }

        public Account(string firstname, string lastname, int accountNumber, double balance): this()
        {
            FirstName = firstname;
            LastName = lastname;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public Account(string firstname, string lastname, int accountnumber, double balance, string email) : this(firstname, lastname, accountnumber, balance)
        {
            Email = email;
        }
    }
}
