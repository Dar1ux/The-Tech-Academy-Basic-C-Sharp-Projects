using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] sArray = { "This is first sentence.", "This is another sentence.", "Message in a bottle.", "Roses are red.", "This is the last sentence in the array."};
            bool validIndex = false; // Defining bool variable and assigning it a value
            Console.WriteLine("Please choose index of an array [0-4]:");
            int i;
            while (!validIndex) // While loop runs until try/catch statment goes through without errors with valid array index
            {
                try
                {
                    i = Convert.ToInt32(Console.ReadLine()); // Reads user's input and tries to convert it to an integer value
                    Console.WriteLine(sArray[i]); // Prints element from the array to the screen at an index i
                    validIndex = true; // Changes validIndex value to true to stop the while loop
                }
                catch
                {
                    Console.WriteLine("Wrong index. Please try again."); // This is printed to the screen if correct index is not provided
                }
            }

            // 2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] numArray = { 125, 223, 735, 2938, 923, 1 }; // Defining an array
            validIndex = false;

            Console.WriteLine("Please choose index of an array [0-5]:");
            while (!validIndex)
            {
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numArray[i]);
                    validIndex = true;
                }
                catch
                {
                    Console.WriteLine("Wrong index. Please try again.");
                }
            }

            // 3. Add in a message that displays when the user selects an index that doesn’t exist.
            // I used try/catch statement to run Console.WriteLine("Wrong index. Please try again."); in above code

            // 4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

            List<string> fruit = new List<string> { "Apple", "Banana", "Pear", "Orange", "Mango", "Melon", "Pineapple"};
            validIndex = false;

            Console.WriteLine("Please choose index of an array [0-6]:");
            while (!validIndex)
            {
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(fruit[i]);
                    validIndex = true;
                }
                catch
                {
                    Console.WriteLine("Wrong index. Please try again.");
                }
            }

            Console.ReadLine(); // Waiting for user's input before closing the window
        }
    }
}
