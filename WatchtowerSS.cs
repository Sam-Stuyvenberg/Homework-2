using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Sam Stuyvenberg
// 02/03/2025 

// Ask the user for an x value as well as a y value. These are coordinates of the enemy relatice to the watchtower's location.
// Using the image from the textbook as a reference, if statements and relational operatiors, display a message about which direction the enemy is coming from.
namespace Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the x coordinates of the enemy?");               // Get X coordinates as input from user and conver to int.
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the y coordinates of the enemy");                // Get Y coordinates as input from user and conver to int.
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 0 && y == 0) Console.WriteLine("The enemy is HERE!!");            // Calculation done by if statements and realtional operators.
            if (x == 0 && y > 0) Console.WriteLine("The enemy is North!");
            if (x == 0 && y < 0) Console.WriteLine("The enemy is South!");
            if (x < 0 && y == 0) Console.WriteLine("The enemy is West!");
            if (x > 0 && y == 0) Console.WriteLine("The enemy is East!");
            if (x < 0 && y > 0) Console.WriteLine("The enemy is Northeast!");
            if (x > 0 && y > 0) Console.WriteLine("The enemy is Northwest!");
            if (x < 0 && y < 0) Console.WriteLine("The enemy is Southwest!");
            if (x > 0 && y < 0) Console.WriteLine("The enemy is Southeast!");
        }
    }
}
