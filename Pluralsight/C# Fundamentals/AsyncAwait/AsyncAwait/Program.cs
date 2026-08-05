global using static System.Console;
using Breakfast;
namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Coffee.PourCoffee();
            Egg.FryEggs(2);
            HashBrown.FryHashBrowns(3);
            Toast.ToastBread(2);
            Toast.ApplyJam();
            Toast.ApplyButter();
            
            ReadKey();
        }
    }
}
