using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly_Test_OOP
{
    internal class Customer : Person
    {

        public List<Sale> PurchasesList = new List<Sale>();

        public Customer() { }
        public Customer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void PrintPurchasesList() 
        {
            WriteLine($"Purchases list for customer: {FirstName} {LastName}");
            WriteLine();
            foreach (Sale purchase in PurchasesList)
            {
                WriteLine($"Product: {purchase.ProductName}, Price: {purchase.Price:C}, Employee: {purchase.Employee?.FirstName} {purchase.Employee?.LastName}, Date: {purchase.TransactionDate}");
            }
        }

        public double GetTotalSpent()
        {
            double total = 0;
            foreach (var purchase in PurchasesList)
            {
                total += purchase.Price;
            }
            return total;
        }

        public void PrintTotalSpent() 
        {
            WriteLine($"Total spent by customer {FirstName} {LastName}: {GetTotalSpent():C}");
        }

    }
}
