using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }

            try
            {
                int userInputInt = int.Parse(userInput);
            }
            // (Exception) --> generic exception error
            // (FormatException) --> more specific to the type of error
            // (OverflowException) --> to large of an input type was entered
            // (ArgumentNullException) --> when a user does not enter anything
            
            // catch (ArgumentNullException)
            // {
            //     Console.WriteLine("Null exception. Please enter a valid number");
            // }
            catch (FormatException)
            {
                // If code in try block is caught (aka. a string is entered),
                // the catch block will be executed
                Console.WriteLine("Format exception. Please only enter numbers.");
                // throw; --> just shows the error
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was to large. Please enter a smaller number."); ;
            }
            catch (Exception)
            {
                Console.WriteLine("General exception. Something went wrong");
            }
            finally // always executes
            {
                Console.WriteLine("Try and catch done.");
            }

            Console.ReadKey();
        }
    }
}
