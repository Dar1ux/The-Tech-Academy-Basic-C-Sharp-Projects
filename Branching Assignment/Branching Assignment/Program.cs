using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine()); // Takes in weight and converts it to an integer
            if (weight > 50)
            {
                // If weight is greater than 50 this message is printed on a screen and program terminates. 
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); 
            }
            else // If weight is not greater than 50 program continues here
            {
                // Gets the dimentions of a package and assigns values to variables width, height and length
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                if ((width + height + length) > 50)
                {
                    // If combination of dimensions is greater than 50 this message is displayed and program terminates
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else // If package is not too big program continues here
                {
                    int size = height * width * length * weight; // Calculates overall size of a package including its weight
                    double quote = Convert.ToDouble(size) / 100; // Calculates quote
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00") + "\nThank you!"); // Prints estimated quote to the screen. ToString("0.00") formats the price to always show to digits after decimal point
                }

            }
            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
