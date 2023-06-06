using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 8, 18, 57, 88, 100 };
            bool incomplete = true; // bool variable to track if calcualtions have been completed
            Console.WriteLine("Pick a number:");
            
            while (incomplete)
            {
                try
                {
                    int userNumber = Convert.ToInt32(Console.ReadLine()); // Getting user's number and converting it to an integer value
                    foreach (int number in numbers) // Looping through the list of numbers
                    {
                        decimal result = Convert.ToDecimal(number) / Convert.ToDecimal(userNumber); // Converting numbers to decimal data type to get decimal values
                        Console.WriteLine(number + " divided by " + userNumber + " equals " + result);
                    }
                    incomplete = false;
                }
                catch (DivideByZeroException) // Catching divide by zero exception
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                catch (FormatException) // Catching string values
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            }

            Console.WriteLine("\nCalculations completed."); // This is printed once try/catch statement is completed
            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
