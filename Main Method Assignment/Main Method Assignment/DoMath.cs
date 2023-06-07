using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class DoMath
    {
        // 1. Create a class. In that class, create a method that will take in an integer,
        // create a math operation for this integer (addition, subtraction, etc.),
        // then return the answer as an integer.
        public int Operation (int number)
        {
            int square = number * number;
            return square;
        }

        // 3. Add a second method to the class with the same name that will take in a decimal,
        // create a different math operation for it, then return the answer as an integer.
        public int Operation(decimal number)
        {
            decimal result = number - 10;
            return Convert.ToInt32(result);
        }

        // 5. Add a third method to the class, with the same name, that will take in a string,
        // convert it to an integer if possible, do a different math operation to it, then
        // return the answer as an integer.
        public int Operation(string number)
        {
            try
            {
                int n = Convert.ToInt32(number);
                int result = n / 2;
                return result;
            }
            catch
            {
                Console.WriteLine("\nUnable to convert '{0}' to an integer", number);
                return 0;
            }            
        }

    }
}
