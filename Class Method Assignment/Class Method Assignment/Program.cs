using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, instantiate that class.
            DoMath math = new DoMath();

            // 3. Have the user enter a number. Call the method on that number.
            // Display the output to the screen. It should be the entered number, divided by two. 
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            math.Half(number, out int result);
            Console.WriteLine("Half of your number is " + result);

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
