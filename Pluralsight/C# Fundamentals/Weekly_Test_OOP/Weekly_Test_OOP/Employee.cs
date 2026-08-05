using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly_Test_OOP
{
    internal class Employee : Person
    {
        public double Salary { get; private set; }

        public List<Sale> SalesList = new List<Sale>();

        public Employee() { }
        public Employee(string firstName, string lastName, int age, double salary) : base(firstName, lastName, age)
        {
            Salary = salary;
        }

        public int GetNumberOfSales()
        {
            return SalesList.Count;
        }

        public double GetSalesTotal()
        {
            double total = 0;
            foreach (var sale in SalesList)
            {
                total += sale.Price;
            }
            return total;
        }

        public double GetAverageSale()
        {
            if (SalesList.Count == 0) return 0;
            return GetSalesTotal() / SalesList.Count;
        }

        public void DisplaySalesInfo()
        {
            WriteLine($"Sales statistics for employee: {FirstName} {LastName}");
            WriteLine();
            WriteLine($"Number of Sales: {GetNumberOfSales()}");
            WriteLine($"Total Revenue: {GetSalesTotal():C}");
            WriteLine($"Average Sale: {GetAverageSale():C}");
        }

        public void PrintSales()
        {
            WriteLine($"Sales for employee: {FirstName} {LastName}");
            WriteLine();
            foreach (Sale sale in SalesList)
            {
                WriteLine($"Product: {sale.ProductName}, Price: {sale.Price:C}, Client: {sale.Client?.FirstName} {sale.Client?.LastName}, Date: {sale.TransactionDate}");
            }
        }

        public void PrintSalesList() 
        {
            WriteLine($"Sales list for employee: {FirstName} {LastName}");
            WriteLine();
            foreach (Sale sale in SalesList)
            {
                WriteLine($"Product: {sale.ProductName}, Price: {sale.Price:C}, Client: {sale.Client?.FirstName} {sale.Client?.LastName}, Date: {sale.TransactionDate}");
            }
        }
    }
}
