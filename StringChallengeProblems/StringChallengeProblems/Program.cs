using System;

namespace StringChallengeProblems
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Challenge #1
            string userInput;
            Console.WriteLine("Please enter your name and press enter: ");
            userInput = Console.ReadLine();
            
            // Can also save into variables and then print to the console
            Console.WriteLine("Upper case: {0}", userInput.ToUpper());
                // ^-- string upperCaseName = String.Format("Upper case : {0}", userInput.ToUpper());
            
            Console.WriteLine("Lower case: {0}", userInput.ToLower());
            // ^-- string lowerCaseName = String.Format("Lower case: {0}", userInput.ToLower());

            Console.WriteLine("No Beginning or Trailing Spaces: {0}", userInput.Trim());
            Console.WriteLine("Substring: {0}", userInput.Substring(0, 5)); // outputs the first 5 digits

            // Challenge #2
            Console.WriteLine("Enter a string here: ");
            // Read first input string
            string text = Console.ReadLine();

            Console.WriteLine("Enter a character to search: ");
            // Read the character input to search
            char searchChar = Console.ReadLine()[0];

            // Gets the index of the character from the string
            int charIndex = text.IndexOf(searchChar);
            // Print results to the console
            Console.WriteLine("The character {0} is located at index {1}", searchChar, charIndex);


            Console.WriteLine("Enter your first name: ");
            // Read the first name
            string firstName = Console.ReadLine();


            Console.WriteLine("Enter your last name: ");
            // Read the last name
            string lastName = Console.ReadLine();

            // Concatinate the first and last name
            string fullName = string.Concat(firstName, " ", lastName);
            // Print the full name to the console
            Console.WriteLine("Your full name is: {0}", fullName);

            Console.ReadKey();
        }
    }
}