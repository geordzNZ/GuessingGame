﻿namespace GuessingGame
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
            Random targetNumber = new Random();
            int target = targetNumber.Next(1,100);

            

        }
    }
}