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

            }

        }
    }
}