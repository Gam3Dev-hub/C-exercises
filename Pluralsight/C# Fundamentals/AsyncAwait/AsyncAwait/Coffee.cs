using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    internal class Coffee
    {
        public Coffee() { }

        public static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
