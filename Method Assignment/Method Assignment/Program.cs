using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class.
            DoMath total = new DoMath();

            // 3. Ask the user to input two numbers, one at a time. Let them know
            // they need not enter anything for the second number.
            Console.WriteLine("Enter price of a unit:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity: [no entry needed if it's just a single unit]");
            
            // 4. Call the method in the class, passing in the one or two numbers entered.
            try
            {
                
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your quote is " + total.Quote(price, quantity));
            }
            catch
            {
                Console.WriteLine("Your quote is " + total.Quote(price));
            }

            Console.ReadLine();
        }
    }
}
