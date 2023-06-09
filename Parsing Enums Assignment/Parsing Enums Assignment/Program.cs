using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        // 1. Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            // 2. Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter a day fo the week:");
            bool validDay = false;
            
            while (!validDay)
            {
                try
                {
                    // 3. Assign the value to a variable of that enum data type you just created.
                    DaysOfTheWeek userDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                    Console.WriteLine("{0} is a day of the week.", userDay);
                    validDay = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }

            // 4. Wrap the above statement in a try/catch block and have it print "Please enter an actual
            // day of the week.” to the console if an error occurs.

            Console.ReadLine();
        }
    }
}
