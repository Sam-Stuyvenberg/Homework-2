using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buying_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build a program that will show the menu illustrated in the texbook
            // Ask the user to enter a number from the menu
            // Using the information above, use a swithc (either type) to show the specific item's cost.

            // The following avalible items are:
            // 1 - Rope
            // 2 - Torches
            // 3 - Climbing Equiptment
            // 4 - Clean Water
            // 5 - Machete
            // 6 - Canoe
            // 7 - Food Supplies

            Console.WriteLine("The following items are avalible:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equiptment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What do you want to see the price of?");

            int option = Convert.ToInt32(Console.ReadLine());

            int cost;

            string itemName = option switch                     // Switch used for string values of the items names.
            {
                1 => "Ropes",
                2 => "Torches",
                3 => "Climbing Equiptment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies",
                _ => "Unknown"
            };


            cost = option switch                        // Switch used for numerical values representing the price of the items.
            {
                1 => 10,
                2 => 15,
                3 => 25,
                4 => 1,
                5 => 20,
                6 => 200,
                7 => 1,
                _ => 0
            };
            
            Console.WriteLine($" Would you like {itemName}? that item cost {cost} gold.");




        }
    }
}
