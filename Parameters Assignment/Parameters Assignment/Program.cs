using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Instantiate an Employee object with type “string” as its generic parameter.
            // Assign a list of strings as the property value of Things.
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "Apple", "Banana", "Melon", "Pineapple", "Orange" };



            // 4. Instantiate an Employee object with type “int” as its generic parameter.
            // Assign a list of integers as the property value of Things.
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 13, 14, 43, 17, 90 };

            // 5. Create a loop that prints all of the Things to the Console.
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach(int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
