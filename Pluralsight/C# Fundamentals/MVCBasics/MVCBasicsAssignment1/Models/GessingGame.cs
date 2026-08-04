using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Immutable;
using System.Security.Cryptography;

namespace MVCBasicsAssignment1.Models
{
    public class GuessingGame
    {
        public static int NumberToGuess { get; set; }
        public static int NumberOfGuesses { get; set; } = 0;

        static bool IsGuessing { get; set; } = false;

        public int UserGuess { get; set; }

        public static List<int> GuessedNumbers { get; set; } = new List<int> { };

        public static Dictionary<string, (string, int, string, int)> GuessHistory { get; set; } = new Dictionary<string, (string, int, string, int)>();

        public string Message { get; set; } = "Guess a number between 1 and 100.";

        public string name { get; set; } = string.Empty;

        public string correctValue { get; set; } = "Number";

        public string numberOfGuessesString { get; set; } = "Number of guesses";


        public int randomNumber()
        {

            if (IsGuessing == false)
            {
                var rnd = new Random();
                int randomNumber = rnd.Next(1, 101); // Generates a random number between 1 and 100
                NumberToGuess = randomNumber;

                IsGuessing = true;
                return randomNumber;
            }
            return NumberToGuess;
        }


        public string CheckGuess(int userGuess)
        {
            if (userGuess < NumberToGuess)
            {
                Message = "Too low! Try again.";
                if (!GuessedNumbers.Contains(userGuess))
                {
                    NumberOfGuesses++;
                    GuessedNumbers.Add(userGuess);
                }
            }
            else if (userGuess > NumberToGuess)
            {
                Message = "Too high! Try again.";
                if (!GuessedNumbers.Contains(userGuess))
                {
                    NumberOfGuesses++;
                    GuessedNumbers.Add(userGuess);
                }
            }
            else
            {
                if (!GuessedNumbers.Contains(userGuess))
                {
                    NumberOfGuesses++;
                    GuessedNumbers.Add(userGuess);
                    GuessHistory.Add(name, (correctValue, userGuess, numberOfGuessesString, NumberOfGuesses));
                }
                GuessHistory = GuessHistory.OrderBy(x => x.Value.Item4).ToDictionary(x => x.Key, x => x.Value);
                Message = $"Congratulations! You guessed the number {NumberToGuess} in {NumberOfGuesses} guesses.";
                
                ResetGame();
            }
            return Message;
        }

        public void AddGuessToHistory(string playerName, int guess)
        {
            if (!GuessHistory.ContainsKey(playerName))
            {
                GuessHistory[playerName] = (correctValue, NumberOfGuesses, numberOfGuessesString, NumberOfGuesses);
            }
        }

        public void ResetGame()
        {
            IsGuessing = false;
            NumberOfGuesses = 0;
            GuessedNumbers.Clear();
            randomNumber(); // Generate a new number for the next game
        }

        public void SetPlayerName(string playerName)
        {
            if (!GuessHistory.ContainsKey(playerName))
            {
                name = playerName;
            }
            else
            {
                name = playerName + "_" + (GuessHistory.Count + 1).ToString();
            }
        }
    }
}
