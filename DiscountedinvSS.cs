using System;

namespace Buying_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build a program that will show the menu illustrated in the textbook
            // Ask the user to enter a number from the menu
            // Using the information above, use a switch (either type) to show the specific item's cost.

            // The following available items are:
            // 1 - Rope
            // 2 - Torches
            // 3 - Climbing Equipment
            // 4 - Clean Water
            // 5 - Machete
            // 6 - Canoe
            // 7 - Food Supplies

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What do you want to see the price of?");

            int option = Convert.ToInt32(Console.ReadLine());

            // Switch used for string values of the item names.
            string itemName = option switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies",
                _ => "Unknown"
            };

            // Switch used for numerical values representing the price of the items.
            float cost = option switch
            {
                1 => 10f,
                2 => 15f,
                3 => 25f,
                4 => 1f,
                5 => 20f,
                6 => 200f,
                7 => 1f,
                _ => 0f
            };

            // Apply a discount if the user’s name is "Sam"
            if (name.Equals("Sam", StringComparison.OrdinalIgnoreCase))
                cost /= 2;

            Console.WriteLine($"Would you like {itemName}? That item costs {cost} gold.");
        }
    }
}
