using Inheritane.Classes;
using Inheritane.Interfaces;

namespace Inheritane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            // The following two calls do what you would expect. They call  
            // the methods that are defined in BaseClass.  
            bc.Method1();
            bc.Method2();
            // Output:  
            // Base - Method1  
            // Base - Method2  

            // The following two calls do what you would expect. They call  
            // the methods that are defined in DerivedClass.  
            dc.Method1();
            dc.Method2();
            // Output:  
            // Derived - Method1  
            // Derived - Method2  

            // The following two calls produce different results, depending
            // on whether override (Method1) or new (Method2) is used.  
            bcdc.Method1();
            bcdc.Method2();
            // Output:  
            // Derived - Method1  
            // Base - Method2  ;


            //Square square = new Square(5);
            //Child childObj = new Child("John", "Doe");
            //ITest test = childObj; // Upcasting to ITest interface

            //test.MethodA(); // Calling the method through the interface
        }
    }
}
