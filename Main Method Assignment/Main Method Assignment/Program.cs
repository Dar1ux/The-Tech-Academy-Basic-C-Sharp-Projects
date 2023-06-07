using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class and call
            // the one method, passing in an integer. Display the result to the screen.
            DoMath math = new DoMath();
            Console.WriteLine("13 squared equals " + math.Operation(13));

            // 4. In the Main() method of the console app, instantiate the class and call
            // the second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine("\n13.345 minus 10 without decimals equals " + math.Operation(13.345m));

            // 6. In the Main() method of the console app, instantiate the class and call
            // the third method, passing in a string that equates to an integer.
            // Display the result to the screen.
            Console.WriteLine("\nHalf of 24 is " + math.Operation("24"));

            Console.ReadLine();
        }
    }
}
