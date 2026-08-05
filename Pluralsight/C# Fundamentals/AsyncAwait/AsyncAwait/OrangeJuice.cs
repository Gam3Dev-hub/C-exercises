using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    internal class OrangeJuice
    {
        public OrangeJuice() { }

        public static OrangeJuice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new OrangeJuice();
        } 
    }
}
