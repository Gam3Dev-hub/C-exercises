using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    internal class HashBrown
    {
        public HashBrown() { }

        public static HashBrown FryHashBrowns(int patties)
        {
            Console.WriteLine($"putting {patties} hash brown patties in the pan");
            Console.WriteLine("cooking first side of hash browns...");
            Task.Delay(3000).Wait();
            for (int patty = 0; patty < patties; patty++)
            {
                Console.WriteLine("flipping a hash brown patty");
            }
            Console.WriteLine("cooking the second side of hash browns...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put hash browns on plate");

            return new HashBrown();
        }
    }
}
