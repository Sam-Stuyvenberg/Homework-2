// Written by Sam Stuyvenberg
// 02/04/2025
using System;

namespace The_Prototype1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; // Declare the variable before using it

            // Write a program that will allow the user, the pilot to enter a number. 
            // Check if the number is above 100 or less than 0, keep asking.
            do
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                number = Convert.ToInt32(Console.ReadLine()); // Assign value to the declared variable

            } while (number < 0 || number > 100); // Loop until a valid number is entered

            // Clear the screen once the program has collected a good number.
            Console.Clear();

            // Ask the Second user, the hunter, to guess numbers.
            Console.WriteLine("User 2, guess the number");

            int guess; // Declare the variable for the hunter's guess

            // Loop until they get it right, then end the program
            do
            {
                Console.Write("What is your next guess? ");
                guess = Convert.ToInt32(Console.ReadLine());

                // Indicate whether the user guessed too high, too low, or guessed right.
                if (guess == number)
                {
                    Console.WriteLine("You guessed the number!");
                }
                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is too low.");
                }
                else
                {
                    Console.WriteLine($"{guess} is too high.");
                }

            } while (guess != number); // Keep looping until the correct number is guessed

            Console.WriteLine("Game Over! Thanks for playing.");
        }
    }
}
