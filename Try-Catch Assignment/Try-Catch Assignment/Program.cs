using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try/Catch Assignment
            // Perform these actions and create a console app that includes the following:
            // 1. Ask the user for their age.
            Console.WriteLine("What is your age?");
            int age = 0;
            bool validAge = false;

            while (!validAge)
            {
                // 3. Exceptions must be handled using “try/catch.”
                try
                {
                    age = Convert.ToInt32(Console.ReadLine()); // Trying to convert user input to an integer value
                    if (age <= 0)
                    {
                        throw new BadAgeException();
                    }
                    validAge = true;
                }
                catch (BadAgeException)
                {
                    // 4. Display appropriate error messages if the user enters zero or negative numbers.
                    Console.WriteLine("Your age must be a positive number.");
                }
                // 5. Display a general message if an exception was caused by anything else.
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Your entry was not accepted. Try again.");
                }
            }

            // 2. Display the year the user was born.
            DateTime currentDate = DateTime.Now;
            int currentYear = 0;
            int.TryParse(currentDate.Year.ToString(), out currentYear);
            Console.WriteLine("You were born in " + (currentYear - age));

            Console.ReadLine();
        }
    }
}
