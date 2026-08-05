using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly_Test_OOP
{
    internal class Sale
    {
        public string? ProductName { get; set; }
       public double Price { get; set; }
       public Customer? Client { get; set; }
       public Employee? Employee { get; set; }
       public DateTime TransactionDate { get; set; }

        public Sale() { }
        public Sale(string productName, double price, Customer client, Employee employee)
        {
            ProductName = productName;
            Price = price;
            Client = client;
            Employee = employee;
            TransactionDate = DateTime.Now;
        }

        internal void AddSale(Employee employee, Customer customer, Sale sale) 
        {
            employee.SalesList.Add(sale);
            customer.PurchasesList.Add(sale);
        }

        internal void AddSale(Sale sale)
        {
            if (sale.Employee != null && sale.Client != null)
            {
                sale.Employee.SalesList.Add(sale);
                sale.Client.PurchasesList.Add(sale);
            }
        }
    }
}
