using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datetime Assignment
            // Perform these actions and create a console app that includes the following:
            // 1. Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);

            // 2. Asks the user for a number.
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // 3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.Write("In {0} hours it will be ", number);
            Console.WriteLine(DateTime.Now.AddHours(number));

            Console.ReadLine();
        }
    }
}
