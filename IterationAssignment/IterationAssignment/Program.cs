using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console App Assignment Part 1
            // 1. A one-dimensional array of strings.
            Console.WriteLine("Console App Assignment Part 1");
            string[] fruits = { "Apple", "Banana", "Melon", "Lemon", "Orange", "Pineapple" };
            // 2. Ask the user to input some text.
            Console.WriteLine("Please input some text:");
            string userInput = Console.ReadLine();
            // 3. A loop that iterates through each string in the array and adds the user's
            // text input to the end of each string. This step will not output anything to
            // the console, but will update each array element by appending the user's text.
            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i] = fruits[i] + userInput;
            }
            // 4. Then create a second loop that prints off each string in the array one at a time.
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Console App Assignment Part 2
            // Add the following to your console app and perform these actions:
            // 1. An infinite loop.
            Console.WriteLine("\nConsole App Assignment Part 2");
            int j = 1;
            while ( fruits[j].Contains("Banana") )
            {
                Console.WriteLine("Infinite Loop!!!");
                j++; // 3.& 4. After increasing j by 1, while loop moves on to the next item in the array
            }

            // Console App Assignment Part 3
            // Add the following to your console app and perform these actions:
            // 1. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            Console.WriteLine("\nConsole App Assignment Part 3");
            for ( int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("fruits[" + i + "]=" + fruits[i]);
            }
            // 2. Save and execute your code.
            // 3. Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("");
            for(int i = 0; i <= fruits.Length - 1; i++)
            {
                Console.WriteLine("fruits[" + i + "]=" + fruits[i]);
            }
            // 4. Save and execute your code.

            // Console App Assignment Part 3
            // Add the following to your console app and perform these actions:
            // 1. A list of strings where each item in the list is unique.
            Console.WriteLine("\nConsole App Assignment Part 4");
            List<string> names = new List<string>() { "Robert", "Loreta", "Marian", "James", "Jesse", "Lily"};
            // 2. Ask the user to input text to search for in the list.
            Console.WriteLine("Please enter a name:");
            string inputName = Console.ReadLine();
            // 3. A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            bool islisted = false;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == inputName)
                {
                    Console.WriteLine(inputName + " is at index [" + i + "]");
                    islisted = true;
                    break;
                }
            }
            // 4. Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
            if (!islisted)
            {
                Console.WriteLine("The name you entered is not listed.");
            }
            // 5. Add code that stops the loop from executing once a match has been found.
            // Added 'break;' in the if statement

            // 6. Save and execute your code.

            // Console App Assignment Part 5
            // Add the following to your console app and perform these actions:
            // 1. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            Console.WriteLine("\nConsole App Assignment Part 5");
            List<string> cars = new List<string>()
            {
                "Ford",
                "Volvo",
                "Ford",
                "Mercedes",
                "BMW",
                "Tesla",
                "Ford",
                "Audi"
            };
            Console.WriteLine("Please enter a car manufacturer:");
            string userCar = Console.ReadLine();
            // 2. Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            // Ensure to remove any break statements that may prevent your code from returning multiple matches.
            bool carListed = false;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i] == userCar)
                {
                    Console.WriteLine(userCar + " found at index [" + i + "]");
                    carListed = true;
                }
            }
            // 3. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not
            // on the list. (You do not need to provide any additional chances for the user to enter text.)
            if (!carListed)
            {
                Console.WriteLine("This car manufacturer is not on our list.");
            }
            // 4. Save and execute your code.

            // Console App Assignment Part 6
            // Add the following to your console app and perform these actions:
            // 1. Create a list of strings that has at least two identical strings in the list. 
            Console.WriteLine("\nConsole App Assignment Part 6");
            List<string> colors = new List<string>()
            {
                "blue",
                "red",
                "red",
                "blue",
                "green",
                "black",
                "pink",
                "red",
                "yellow"
            };
            // 2. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has
            // already appeared in the list.
            int n = 0;
            bool unique = true;
            foreach ( string color in colors)
            {
                if ( n > 0 ) // Makes sure it's not the first item in the list
                {
                    for ( int i = 0; i < n; i++) // Loop for all previous items in the list
                    {
                        if (colors[i] == color) // Checks if it's a duplicate
                        {
                            unique = false;                            
                            break;                            
                        }
                    }
                }
                if (unique)
                {
                    Console.WriteLine(color + " - this item is unique");
                }
                else
                {
                    Console.WriteLine(color + " - this item is a duplicate");
                }
                unique = true;
                n++;
            }
            // 3. Save and execute your code.

            Console.ReadLine();
        }
    }
}
