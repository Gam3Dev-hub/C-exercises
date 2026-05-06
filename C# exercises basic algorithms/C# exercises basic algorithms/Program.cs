using System.Text;
using static System.Math;

namespace C__exercises_basic_algorithms
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //Triple sums for equal integers
            //TripleSumForEqualInt();
            //AbsoluteDifferenceWithTriple();
            //ThirtyOrSumThirty();
            //WithinTenOfOneHundredOrTwoHundred();
            //AddIfToStringIfAbscent();
            //RemoveCharFromList();
            //ReplaceLetters();
            //ReplaceLetters();
            //FirstTwoFourTimes();
            //LastCharFrontAndBack();
            //MultipleOfThreeOrSeven();
            EvenOrOddBitwise();
        }



        static protected int TripleSumForEqualInt()
        {
            Console.WriteLine("Sum of numbers will be trippled if they are the same");
            Console.WriteLine("Write first number to add: \t");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Write first number to add: \t");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            if (a == b)
            {
                sum *= 3;
                Console.WriteLine($"Triple sum of numbers is: a: {a} + {b} * 3 = {sum}");
                return sum;
            }
            else
            {
                Console.WriteLine($"sum of numbers is: a: {a} + {b} = {sum}");
                return sum;
            }
        }

        static protected int AbsoluteDifferenceWithTriple()
        {
            const int x = 51;
            Console.WriteLine($"The absolute difference between n");
            int number = int.Parse(Console.ReadLine());
            int absoluteDifferenceTimesThree = Abs((x - number)) * 3;
            int absoluteDifference = (x - number);
            if (number > x)
            {
                Console.WriteLine($"Tripple absolute difference = {x} - {number} = {absoluteDifferenceTimesThree}");
                return absoluteDifferenceTimesThree;
            }
            else
            {
                Console.WriteLine($"absolute difference = {x} - {number} = {absoluteDifference}");
                return absoluteDifference;
            }
        }

        static protected bool ThirtyOrSumThirty() 
        {
            Console.WriteLine("Write first number sum");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number sum");
            int b = int.Parse(Console.ReadLine());

            if(a == 30 ^ b == 30)
            {
                Console.WriteLine("A or B = 30");
                return true;
            }
            else if(a + b == 30)
            {
                Console.WriteLine($"a: {a} + b {b} = {a + b}");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        static protected bool WithinTenOfOneHundredOrTwoHundred()
        {
            int num = int.Parse(Console.ReadLine());
            if(Abs(num - 10) <= 10 || Abs(num -100) <= 10 || Abs(num - 200) <= 10)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
            
        }

        static protected string AddIfToStringIfAbscent()
        {
            Console.WriteLine("Write a string with or without if");
            String inputString = Console.ReadLine();
            String outputString;
            int numIterations = 0;
            Console.WriteLine($"Input string length: {inputString.Length}");
            for (int i = 0; i < inputString.Length; i++) 
            {
                numIterations++;
                Console.WriteLine($"{inputString[i]} at index: {i}");
                if (inputString[i] == 'i' && inputString[i + 1] == 'f')
                {
                    Console.WriteLine($"{inputString[i + 1]} at index: {i+1}");
                    Console.Write("succsess! ");
                    Console.WriteLine($"if was found at index: {i} and {i+1}");
                    return inputString;
                }
            }
            Console.WriteLine($"Number of iterations: {numIterations}");
            Console.WriteLine("\"if\" was not found in your string! It was subsequently added to the front of your string");
            outputString = "If " + inputString;
            Console.WriteLine(outputString);
            return outputString;
        }

        static protected List<char> RemoveCharFromList()
        {
            List<char> inputList = new List<char>();
            int indexToRemove;
            Console.Write("Write a string to add to the list \t");
            String inputString = Console.ReadLine();
            foreach(char letter in inputString)
            {
                inputList.Add(letter);
            }
            Console.Write($"Input which index to remove in the list[index between {0} and {inputList.Count - 1}] ");
            try
            {
                indexToRemove = int.Parse(Console.ReadLine());
                if(indexToRemove <= inputList.Count - 1)
                {
                    Console.WriteLine($"Removing char from index: {indexToRemove}");
                    Console.WriteLine($"Removing char: {inputList[indexToRemove]} from list");
                    inputList.RemoveAt(indexToRemove);
                }
                else if(indexToRemove > inputList.Count -1)
                {
                    Console.WriteLine("Index out of range exception encountered");
                    RemoveCharFromList();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine($"Wrong format exception, please provide a number between {0} and {inputList.Count - 1}]");
                RemoveCharFromList();
            }
            /*
            finally
            {
                Console.WriteLine($"Wrong format exception, please provide a number between {0} and {inputList.Count - 1}]");
                indexToRemove = int.Parse(Console.ReadLine());
                inputList.RemoveAt(indexToRemove);
            }
            */

            foreach (char letter in inputList)
            {
                Console.Write(letter);
            }
            return inputList;
        }
        

        static protected void ReplaceLetters()
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            char firstChar = sb[0];
            char lastChar = sb[sb.Length - 1];
            String outputString = lastChar + sb.ToString().Substring(1, sb.Length -2) + firstChar;
            Console.WriteLine(outputString);
        }

        static protected void FirstTwoFourTimes()
        {
            Console.WriteLine("Write a string to duplicate fist two characters 4 times");
            String userInput = Console.ReadLine();
            if (userInput.Length <= 2)
                Console.WriteLine(userInput);
            else
                for (int i = 0; i < 4; i++)
                    Console.Write($"{userInput.Substring(0, 2)} ");
        }

        static protected void LastCharFrontAndBack()
        {
            Console.WriteLine("Write a sentence or word to add last letter in front and back");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            char lastchar = sb[sb.Length - 1];
            String outputString;
            if (sb.Length < 1)
                Console.WriteLine(sb.ToString());
            else
            {
                outputString = lastchar + sb.ToString() + lastchar;
                Console.WriteLine(outputString);
            }
        }
        static protected bool MultipleOfThreeOrSeven()
        {
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 3 == 0 || userInput % 7 == 0)
            {
                Console.WriteLine(userInput);
                return true;
            }
            else
                Console.WriteLine("not a multiple of 3 or 7");
            return false;
                
        }

        static protected bool EvenOrOddBitwise()
        {
            int userinput = int.Parse(Console.ReadLine());
            bool isEven;
            if(isEven = (userinput & 1) == 0)
            {
                Console.WriteLine(userinput);
                Console.WriteLine(isEven);
                return isEven;
            }
            else
            {
                Console.WriteLine(isEven);
                return isEven;
            }
        }
    }
}
