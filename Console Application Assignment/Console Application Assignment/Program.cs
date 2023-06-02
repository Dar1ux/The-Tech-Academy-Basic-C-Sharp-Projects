using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Please enter a number to be multiplied by 50:");
            string tempNumber = Console.ReadLine(); // Takes number from user input
            int result = Convert.ToInt32(tempNumber); // Converts user input to integer variable
            int product = result * 50; // Performs multiplication
            Console.WriteLine(tempNumber + " multiplied by 50 = " + product + "\n"); // Prints result to the screen

            Console.WriteLine("2. Please enter a number to be added with 25:");
            tempNumber = Console.ReadLine();
            result = Convert.ToInt32(tempNumber);
            product = result + 25; // Performs addition
            Console.WriteLine(tempNumber + " plus 25 = " + product + "\n");

            Console.WriteLine("3. Please enter a number to be divided by 12.5:");
            tempNumber = Console.ReadLine();
            result = Convert.ToInt32(tempNumber);
            double quotient = result / 12.5; // Performs division
            Console.WriteLine(tempNumber + " divided by 12.5 = " + quotient + "\n");

            Console.WriteLine("4. Please enter a number to be checked if it is greater than 50:");
            tempNumber = Console.ReadLine();
            result = Convert.ToInt32(tempNumber);
            bool trueFalse = result > 50; // Performs comparison operation and assigns result to boolean variable
            Console.WriteLine(tempNumber + " > 50. That is " + trueFalse + "\n");

            Console.WriteLine("5. Please enter a number to be divide by 7. Remainder will be shown.");
            tempNumber = Console.ReadLine();
            result = Convert.ToInt32(tempNumber);
            product = result % 7; // Performs division and assigns remainder to variable
            Console.WriteLine(tempNumber + " divided by 7 has a remainder of " + product + "\n");

            Console.ReadLine(); // Waiting for user input before closing the window

        }
    }
}
