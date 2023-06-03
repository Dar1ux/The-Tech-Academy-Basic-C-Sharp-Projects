using System;


namespace Console_App_Assignment
{
    class Program
    {
        static void Main()
        {
            // 1. Do a boolean comparison using a while statement.

            // Getting number from a user and converting it to integer
            Console.WriteLine("Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            // Running while loop until number equals to 17
            while (number != 17)
            {
                Console.WriteLine("Incorrect. Guess again.");
                number = Convert.ToInt32(Console.ReadLine());
            }
            // Message printed once number is guess and while loop ends
            Console.WriteLine("\n17 is a correct number!");

            // 2. Do a boolean comparison using a do while statement.

            // Getting a letter from a user and converting it to char data type
            Console.WriteLine("\nGuess a lower case letter.");
            char letter = Convert.ToChar(Console.ReadLine());
            bool trueLetter = letter == 'd'; // Defining boolean variable for correct letter

            // Do While loop with switch statement to be ran until letter is guessed
            do
            {
                switch (letter)
                {
                    case 'd': // Correct case
                        Console.WriteLine("\nd is a correct letter!");
                        trueLetter = true;
                        break;
                    default: // Any other case
                        Console.WriteLine("Incorrect. Guess again.");
                        letter = Convert.ToChar(Console.ReadLine());
                        break;
                }
            }
            while (!trueLetter);

            Console.ReadLine(); // Waiting for user input before closing the window
        }
    }
}
