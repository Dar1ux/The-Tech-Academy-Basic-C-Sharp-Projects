using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating 2 employees
            Employee e1 = new Employee() { Id = 101, FirstName = "Jesse", LastName = "Smith" };
            Employee e2 = new Employee() { Id = 102, FirstName = "Rob", LastName = "Jones" };

            // Comparing 2 employees
            Console.WriteLine(e1 == e2);

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
