using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Gets information for Person 1
            Console.WriteLine("Person 1\n");
            Console.WriteLine("Hourly rate?");
            string temp = Console.ReadLine(); // Reads user input
            int hourly1 = Convert.ToInt32(temp); // Converts user input to integer value and assigns to a variable
            Console.WriteLine("\nHours worked per week?");
            temp = Console.ReadLine();
            int hours1 = Convert.ToInt32(temp);

            // Same operations just for Person 2
            Console.WriteLine("\nPerson 2\n");
            Console.WriteLine("Hourly rate?");
            temp = Console.ReadLine();
            int hourly2 = Convert.ToInt32(temp);
            Console.WriteLine("\nHours worked per week?");
            temp = Console.ReadLine();
            int hours2 = Convert.ToInt32(temp);

            // Calculates Person 1 annual salary
            Console.WriteLine("\nAnnual salary of Person 1:");
            int annual1 = hourly1 * hours1 * 52;
            Console.WriteLine(annual1);

            // Calculates Person 2 annual salary
            Console.WriteLine("\nAnnual salary of Person 2:");
            int annual2 = hourly2 * hours2 * 52;
            Console.WriteLine(annual2);

            bool moreMoney = annual1 > annual2; // Compares first annual salary to a second and assigns true/false value to a variable
            Console.WriteLine("\nPerson 1 makes more money than Person 2");
            Console.WriteLine(moreMoney); // Prints true/false value to the screen

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
