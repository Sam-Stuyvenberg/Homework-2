// Written by Sam Stuyvenberg
// 02/04/2025

namespace The_Magic_Cannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)           // Detect appropriate Number value
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;        // Assign Color
                    Console.WriteLine($"{number}: Electric and Fire");
                }
                else if (number % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;      // Assign Color
                    Console.WriteLine($"{number}: Electric");
                }
                else if (number % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;         // Assign Color
                    Console.WriteLine($"{number}: Fire");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;            // Assign Color
                    Console.WriteLine($"{number}: Normal");             
                }
            }
        }
        }
    }

