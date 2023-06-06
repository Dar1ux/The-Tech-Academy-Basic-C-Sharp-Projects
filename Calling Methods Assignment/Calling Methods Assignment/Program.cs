using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            int number = Convert.ToInt32(Console.ReadLine()); // getting input from a user and converting to an integer value

            // Calling different methods from DoMath class and printing out the result
            Console.WriteLine(number + " squared equals " + DoMath.Square(number));
            Console.WriteLine(number + " added to itself equals " + DoMath.AddItself(number));
            Console.WriteLine(number + " negative value is " + DoMath.Negative(number));

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
