namespace Bitwise_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint Bitwise = 0b_0000_0000_0000_0000_0000_0000_0000_0001;
            Bitwise = 1 << 7;
            Console.WriteLine($"Bitwise shift {Bitwise}");
            Bitwise >>= 4;
            Console.WriteLine($"Bitwise shift {Bitwise}");
            Bitwise = 3 << 3;
            Console.WriteLine($"Bitwise shift {Convert.ToString(Bitwise, toBase :2)}");
            Console.WriteLine($"Bitwise shift {Bitwise}");


        }
    }
}
