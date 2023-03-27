namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Header section
            Console.WriteLine("\t\t\tWELCOME");
            Console.WriteLine("\t\t  Number Guessing Game");
            Console.WriteLine("==========================================================\n");

            // Generate Random number
            Random target = new Random();
            int targetNumber = target.Next(1,100);

            // Game loop
            bool targetGuessed = false;
            while (!targetGuessed)
            {
                Console.Write($"\tGuess a number: ");
                string guessedNumberInput = Console.ReadLine();
                int guessedNumber = Int32.Parse(guessedNumberInput);

                if (guessedNumber == targetNumber)
                {
                    Console.WriteLine($"\n\n\tWINNER WINNER, YOU GUESSED { targetNumber } CORRECTLY!!!");
                    Console.WriteLine("\n==========================================================\n");

                    targetGuessed = true;
                }
                else
                {
                    if ((targetNumber - guessedNumber) >= 1)
                    {
                        Console.Write($"\n\tToo low   --> ");
                    }
                    else
                    {
                        Console.Write($"\n\tToo high  --> ");
                    }
                }
            }

        }
    }
}