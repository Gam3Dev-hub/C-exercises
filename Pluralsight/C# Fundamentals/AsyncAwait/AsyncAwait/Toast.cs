using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    internal class Toast
    {
        public Toast() { }

        public static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        public static void ApplyJam()
        {
            WriteLine("Putting jam on the toast");
        }

        public static void ApplyButter()
        {
            WriteLine("Putting butter on toast");
        }
    }
}
