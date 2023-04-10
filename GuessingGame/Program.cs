namespace GuessingGame
{
    internal class Program
    {
        const int MIN_TARGET = 0;
        const int MAX_TARGET = 100;
        const int ALLOWED_GUESSES = 15;
        const int CLOSE_GUESS_DIFFERENCE = 5;
        static void Main(string[] args)
        {
            int gamesPlayed = 0;
            int gamesWon = 0;
            int totalGuesses = 0;
            bool playAgain = true;

            while (playAgain)
            {
                // Header section
                Console.Clear();
                Console.WriteLine("\t\t\tWELCOME");
                Console.WriteLine("\t\t  Number Guessing Game");
                Console.WriteLine($"\tPick an integer between {MIN_TARGET} and {MAX_TARGET} in {ALLOWED_GUESSES} guesses");

                Console.WriteLine($"\t\tGames played: {gamesPlayed} ... Wins: {gamesWon}");
                Console.WriteLine("==========================================================\n");

                // Generate Random number
                Random target = new Random();
                int targetNumber = target.Next(MIN_TARGET, MAX_TARGET + 1);

                // Game loop
                bool targetGuessed = false;
                int guessCounter = 0;
                gamesPlayed++;

                while (guessCounter < ALLOWED_GUESSES)
                {
                    Console.Write($"\n\t{guessCounter + 1}) Guess a number: ");
                    string guessedNumberInput = Console.ReadLine();

                    // Validate user input
                    int guessedNumber;
                    bool guessedNumberValidation = int.TryParse(guessedNumberInput, out guessedNumber);
                    if ((guessedNumber < MIN_TARGET) || (guessedNumber > MAX_TARGET) || !guessedNumberValidation)
                    {
                        Console.WriteLine($"\t\t{guessCounter + 1}) Enter an interger between {MIN_TARGET} and {MAX_TARGET} - Try again!");
                        continue;
                    }

                    guessCounter++;

                    if (guessedNumber == targetNumber)
                    {
                        targetGuessed = true;
                        break;
                    }
                    else
                    {
                        if (targetNumber > guessedNumber)
                        {
                            Console.WriteLine($"\t\tTOO LOW ... ");
                        }
                        else
                        {
                            Console.WriteLine($"\t\tTOO HIGH ... ");
                        }

                        if (Math.Abs(targetNumber - guessedNumber) <= CLOSE_GUESS_DIFFERENCE)
                        {
                            Console.WriteLine($"\t\tThat was close though, you are within {CLOSE_GUESS_DIFFERENCE}");
                        }
                    }
                }

                if (targetGuessed)
                {
                    Console.Write("\n\n\tWINNER WINNER!!!");
                    Console.Write($"\n\tYOU GUESSED {targetNumber} CORRECTLY");
                    Console.Write($"\n\tTAKING ONLY {guessCounter} GUESSES");
                    gamesWon++;
                    totalGuesses += guessCounter;
                }
                else
                {
                    Console.Write("\n\n\tTOO MANY GUESSES!");
                    Console.Write($"\n\tYOU GUESSED {guessCounter} INCORRECT TIMES");
                    Console.Write($"\n\tTHE CORRECT NUMBER WAS {targetNumber}");
                    totalGuesses += guessCounter;
                }
                Console.WriteLine("\n==========================================================\n");

                bool wrongPlayAgainInput = true;
                string playAgainInput = "";
                while (wrongPlayAgainInput)
                {
                    Console.Write($"\n\tDo you want to play again? (Y/N) ");
                    playAgainInput = Console.ReadLine().ToUpper();

                    //Validate playAgainInput
                    if (playAgainInput != "Y" && playAgainInput != "N")
                    {
                        Console.WriteLine("\t\tPlease entery either Y / N");
                        continue;
                    }
                    wrongPlayAgainInput = false;
                }

                if (playAgainInput == "N")
                {
                    playAgain = false;
                }
            }

            Console.Clear();
            Console.WriteLine("\t\t\tTHANKS FOR PLAYING");
            Console.WriteLine($"\n\tSession data for {gamesPlayed} games(s) played...");
            Console.WriteLine($"\t\tGuesses:\t{totalGuesses}");
            Console.WriteLine($"\t\tGames Won:\t{gamesWon}");
            Console.WriteLine("\n==========================================================\n");
        }
    }
}