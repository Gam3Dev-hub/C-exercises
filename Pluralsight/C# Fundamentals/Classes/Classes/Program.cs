using Classes;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double MonthlySalary = 1249.35;
            int MonthsWorked = 12;
            double result = Utilities.CalculateYearlyWage(MonthlySalary, MonthsWorked, 0);
            Console.WriteLine(result);
        }
    }
}
