using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    // 1. Create a class. In that class, create a void method that takes two integers as parameters.
    // Have the method do a math operation on the first integer and display the second integer to the screen. 
    class DoMath
    {
        public void Operation(int number, int userID)
        {
            int total = (number * 3) + 17;
            Console.WriteLine(userID);
        }
    }
}
