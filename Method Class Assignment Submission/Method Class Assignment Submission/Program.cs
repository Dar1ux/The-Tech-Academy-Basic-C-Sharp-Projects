using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class.
            DoMath math = new DoMath();

            // 3. Call the method in the class, passing in two numbers. 
            math.Operation(13, 100456);

            // 4. Call the method in the class, specifying the parameters by name.
            math.Operation(number: 24, userID: 100332);

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
