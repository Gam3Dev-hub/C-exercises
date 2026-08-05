global using static System.Console;

namespace Weekly_Test_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person test = new Person("Daniel", "Turunen", 39);
            Employee empTest = new Employee("Daniel", "Turunen", 39, 45000);
            Employee empTest2 = new Employee("Jane", "Johnson", 30, 57000);
            Customer custTest = new Customer("John", "Smith", 45);
            Customer custTest2 = new Customer("Emily", "Davis", 28);
            Sale saleTest = new Sale("Gadget", 29.99, custTest, empTest);
            Sale saleTest2 = new Sale("Widget", 19.99, custTest, empTest);
            Sale saleTest3 = new Sale("Sprocket", 29.99, custTest, empTest);
            Sale saleTest4 = new Sale("Hammer", 49.99, custTest, empTest);
            Sale saleTest5 = new Sale("Screwdriver", 9.99, custTest, empTest);
            Sale saleTest6 = new Sale("Wrench", 14.99, custTest, empTest);
            Sale saleTest7 = new Sale("Drill", 89.99, custTest2, empTest2);
            Sale saleTest8 = new Sale("Screws", 9.99, custTest2, empTest2);

            saleTest.AddSale(empTest, custTest, saleTest);
            saleTest2.AddSale(empTest, custTest, saleTest2);
            saleTest3.AddSale(empTest, custTest, saleTest3);
            saleTest4.AddSale(empTest, custTest, saleTest4);
            saleTest5.AddSale(saleTest5);
            saleTest6.AddSale(saleTest6);
            saleTest7.AddSale(saleTest7);
            saleTest8.AddSale(saleTest8);

            test.Speak();

            empTest.DisplaySalesInfo();
            WriteLine("------------------------------------------------------------------------------------------------------");
            empTest.PrintSales();
            WriteLine("------------------------------------------------------------------------------------------------------");
            empTest.PrintSalesList();
            WriteLine("------------------------------------------------------------------------------------------------------");
            custTest.PrintPurchasesList();
            WriteLine("------------------------------------------------------------------------------------------------------");
            custTest.PrintTotalSpent();
            WriteLine("------------------------------------------------------------------------------------------------------");


            empTest2.DisplaySalesInfo();
            WriteLine("------------------------------------------------------------------------------------------------------");
            empTest2.PrintSales();
            WriteLine("------------------------------------------------------------------------------------------------------");
            empTest2.PrintSalesList();
            WriteLine("------------------------------------------------------------------------------------------------------");
            custTest2.PrintPurchasesList();
            WriteLine("------------------------------------------------------------------------------------------------------");
            custTest2.PrintTotalSpent();
            WriteLine("------------------------------------------------------------------------------------------------------");


            ReadKey();
        }
    }
}
