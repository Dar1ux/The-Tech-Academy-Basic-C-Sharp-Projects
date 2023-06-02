using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets user's age, converts and assigns to an integer variable
            Console.WriteLine("What is your age?");
            string temp = Console.ReadLine();
            int age = Convert.ToInt16(temp);

            // Gets true/false answer, converts and assigns it to boolean variable
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            temp = Console.ReadLine();
            bool dui = Convert.ToBoolean(temp);

            // Gets the number od tickets, converts aand assigns to integer variable
            Console.WriteLine("How many speeding tickets do you have?");
            temp = Console.ReadLine();
            int tickets = Convert.ToInt16(temp);

            // Checks if age is more than 15, no DUI's and not more than 3 speeding tickets.
            bool qualified = age > 15 && dui == false && tickets <= 3;

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified); // Prints to the screen if user is qualified for car insurance

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
