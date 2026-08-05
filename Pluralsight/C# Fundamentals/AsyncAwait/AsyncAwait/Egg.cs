using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwait
{
    internal class Egg
    {
        public Egg() { }

        public static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

    }
}
