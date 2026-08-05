using static System.Console;

namespace Weekly_test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Task 1
            WriteLine("Enter a number");
            var userInput = int.TryParse(ReadLine(), out var numOne);
            while (!userInput)
            {
                WriteLine("Invalid input, enter a valid number");
                userInput = int.TryParse(ReadLine(), out numOne);
            }
            WriteLine("Enter another number");
            userInput = int.TryParse(ReadLine(), out var numTwo);
            while (!userInput)
            {
                WriteLine("Invalid input, enter a valid number");
                userInput = int.TryParse(ReadLine(), out numTwo);
            }
            WriteLine("Enter a third number");
            userInput = int.TryParse(ReadLine(), out var numThree);
            while (!userInput)
            {
                WriteLine("Invalid input, enter a valid number");
                userInput = int.TryParse(ReadLine(), out numThree);
            }
            WriteLine($"numone: {numOne}, numtwo: {numTwo}, numthree: {numThree}");
            List<int> numList = new List<int>();
            numList.Add(numOne);
            numList.Add(numTwo);
            numList.Add(numThree);

            double sum = 0;
            double average = 0;

            int smallestNum = numList[0];
            int largestNum = numList[0];

            for (int i = 0; i < numList.Count; i++)
            {
                sum += numList[i];
                if (numList[i] > largestNum)
                    largestNum = numList[i];
                if(numList[i] < smallestNum)
                    smallestNum = numList[i];
            }

            average = sum / numList.Count;

            WriteLine($"minimum value: {smallestNum}");
            WriteLine($"maximum value: {largestNum}");
            WriteLine($"total: {sum}");
            WriteLine($"average: {average}");





            //Task 2

            WriteLine("Display all odd numbers between 30 and 100");
            for (int i = 30; i <= 100; i++)
            {
                if ((i & 1) != 0)
                {
                    WriteLine(i);
                }
            }

            WriteLine();
            WriteLine();

            //task 3

            List<int> randomNumlist = new List<int>();
            Random rand = new Random();
            //int oddNumCount = 0;
            for (int i = 0; i < 20; i++)
            {
                int randomNumber = rand.Next(40, 71);
                randomNumlist.Add(randomNumber);
                //For debugging
                /*
                if ((randomNumlist[i] & 1) != 0)
                {
                    oddNumCount++;
                }
                */
            }
            //For debugging, checking that the list actually has random numbers
            /*
            foreach (int num in randomNumlist)
            {
                WriteLine(num);
            }
            */
            WriteLine();
            //WriteLine($"odd number count {oddNumCount}");
            List<int> numBelow50list = new List<int>();
            List<int> numAbove50list = new List<int>();
            foreach (int num in randomNumlist)
            {
                if (num <= 50)
                    numBelow50list.Add(num);
                else
                    numAbove50list.Add(num);
            }


            foreach (int num in numBelow50list)
            {
                WriteLine($"numbers below 50: {num}");
            }
            WriteLine();
            foreach (int num in numAbove50list)
            {
                WriteLine($"numbers above 50: {num}");
            }
            
            //Task 4

            //Products
            String milk = "Milk";
            String cheese = "cheese";
            String meat = "meat";
            String poultry = "poultry";
            String eggs = "eggs";

            



            //Price
            int milkPrice = 5;
            int cheesePrice = 10;
            int meatPrice = 15;
            int poultryPrice = 20;
            int eggPrice = 8;

            int quantity = 0;
            int paidAmount = 0;

            bool isAtCheckout = false;
            int itemIndex = 0;




            WriteLine("<===== Super(duper)market =====>");
            WriteLine();
            WriteLine("Products:");
            WriteLine($"{milk} {milkPrice}");
            WriteLine($"{cheese} {cheesePrice}");
            WriteLine($"{meat} {meatPrice}");
            WriteLine($"{poultry} {poultryPrice}");
            WriteLine($"{eggs} {eggPrice}");

            int total = 0;
            while (!isAtCheckout)
            {
                WriteLine("Buy groceries! [0]milk, [1]cheese, [2]meat, [3]poultry, [4]eggs");
                while (!(int.TryParse(ReadLine(), out itemIndex) && itemIndex < 5 && itemIndex >= 0))
                {
                    WriteLine("Input a valid grocery index");
                }
                WriteLine("Input quantity");
                while (!(int.TryParse(ReadLine(), out quantity)))
                {
                    WriteLine("Input a valid quantity");
                }

                switch (itemIndex)
                {
                    case 0: WriteLine($"You pick up  {quantity} {milk}"); break;
                    case 1: WriteLine($"You pick up  {quantity} {cheese}"); break;
                    case 2: WriteLine($"You pick up  {quantity} {meat}"); break;
                    case 3: WriteLine($"You pick up  {quantity} {poultry}"); break;
                    case 4: WriteLine($"You pick up  {quantity} {eggs}"); break;
                }

                //WriteLine($"item index: {itemIndex}");
                //WriteLine($"item quantity: {quantity}");

                switch (itemIndex)
                {
                    case 0:
                        total += (milkPrice * quantity);
                        break;
                    case 1:
                        total += (cheesePrice * quantity);
                        break;
                    case 2:
                        total += (meatPrice * quantity);
                        break;
                    case 3:
                        total += (poultryPrice * quantity);
                        break;
                    case 4:
                        total += (eggPrice * quantity);
                        break;
                }
                WriteLine($"Total = {total}");
                WriteLine("Do you wish to continue shopping(type \"no\" or \"No\" to proceed to checkout)?");
                var input = ReadLine();
                if (input == "no" || input == "No") 
                {
                    isAtCheckout = true;
                    WriteLine("Proceeding to checkout...");
                    WriteLine($"Your total is: {total}");
                    WriteLine("Enter price to pay");
                    var pay = int.TryParse(ReadLine(), out paidAmount);
                    while(paidAmount < total)
                    {
                        WriteLine($"Amount paid does not cover your total: {total}");
                        WriteLine("Enter price to pay");
                        pay = int.TryParse(ReadLine(), out paidAmount);
                    }
                    if(paidAmount > total)
                    {
                        WriteLine($"You paid: {paidAmount}, and your total was {total} which means you get back: {paidAmount - total}");
                        WriteLine($"You receive {paidAmount - total}");
                    }
                }
                else
                {
                    isAtCheckout = false;
                }
                    
            }
        }
    }
}
