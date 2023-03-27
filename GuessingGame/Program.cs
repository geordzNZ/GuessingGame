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
            // Header section
            Console.WriteLine("\t\t\tWELCOME");
            Console.WriteLine("\t\t  Number Guessing Game");
            Console.WriteLine($"\tPick a number between {MIN_TARGET} and {MAX_TARGET} in {ALLOWED_GUESSES} guesses");
            Console.WriteLine("==========================================================\n");

            // Generate Random number
            Random target = new Random();
            int targetNumber = target.Next(MIN_TARGET,MAX_TARGET + 1);

            // Game loop
            bool targetGuessed = false;
            int guessCounter = 0;
            
            while (!targetGuessed && (guessCounter < ALLOWED_GUESSES))
            {
                Console.Write($"\tGuess a number: ");
                string guessedNumberInput = Console.ReadLine();
                int guessedNumber = Int32.Parse(guessedNumberInput);

                if (guessedNumber == targetNumber)
                {
                    guessCounter++;
                    targetGuessed = true;
                }
                else
                {
                    bool closeGuess = false;
                    if (Math.Abs(targetNumber - guessedNumber) <= CLOSE_GUESS_DIFFERENCE)
                    {
                        closeGuess = true;
                    }

                    if ((targetNumber - guessedNumber) >= 1)
                    {
                        Console.Write($"\n\tYour guess was TOO LOW ");
                        if (closeGuess)
                        {
                            Console.Write($"but you are within 5 ");
                        }
                        Console.WriteLine("...");
                        guessCounter++;
                    }
                    else
                    {
                        Console.Write($"\n\tYour guess was TOO HIGH ");
                        if (closeGuess)
                        {
                            Console.Write($"but you are within 5 ");
                        }
                        Console.WriteLine("...");
                        guessCounter++;
                    }
                }
            }

            if (targetGuessed)
            {
                Console.Write("\n\n\tWINNER WINNER!!!");
                Console.Write($"\n\tYOU GUESSED {targetNumber} CORRECTLY");
                Console.Write($"\n\tTAKING ONLY {guessCounter} GUESSES");
            }
            else
            {
                Console.Write("\n\n\tTOO MANY GUESSES!");
                Console.Write($"\n\tYOU GUESSED {guessCounter} INCORRECT TIMES");
                Console.Write($"\n\tTHE CORRECT NUMBER WAS {targetNumber}"); 
            }
            Console.WriteLine("\n==========================================================\n");
        }
    }
}