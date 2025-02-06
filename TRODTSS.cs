//Written By Sam Stuyvenberg 
// 02/04/2025

// Make a program that creates an array of length 5.
// Ask the user for five numbers and put them in an array
// Make a second array of length 5
// Use a loop to copy the values out of the original array and into a new one.
// Display the contents of both arrays one at a time to illustrate that the Replicator of D'To works again.

using System;

namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array called 'original' to hold 5 integers
            int[] original = new int[5];

            // Loop to ask the user to input 5 numbers and store them in the 'original' array
            for (int item = 0; item < 5; item++)
            {
                Console.Write("Enter a number: ");                      // Get Number from user
                int number = Convert.ToInt32(Console.ReadLine());      // Convert the input to an integer
                original[item] = number;                               // Store the number in the 'original' array at position 'item'
            }

            // Create a second array called 'copy' with the same size as 'original'
            int[] copy = new int[5];                                  // Initialize the copy array

            // Loop through the 'original' array and copy the values to the 'copy' array
            for (int index = 0; index < 5; index++)
            {
                copy[index] = original[index];                        // Copy each value from 'original' to 'copy' at the same index
            }

            // Display the contents of both arrays side by side to show that they are identical
            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine($"{original[index]} and {copy[index]}");  // Print corresponding values from both arrays
            }
        }
    }
}
