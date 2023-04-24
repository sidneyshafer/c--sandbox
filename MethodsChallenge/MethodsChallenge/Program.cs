using System;

namespace MethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create three variables
            string friendOne = "Allie";
            string friendTwo = "Lisa";
            string friendThree = "Brent";

            // Call the function
            GreetFriend(friendOne);
            GreetFriend(friendTwo);
            GreetFriend(friendThree);

            Console.ReadKey();
        }
        // Create a method which takes in a string argument
        // and prints the string to the console
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi {0}, my friend!", friendName);
        }

        // CODING EXERCISE: TEST YOUR METHODS
        /*
            using System;

            namespace Coding.Exercise
            {
                public class Method
                {
                    // Place for your methods
                    public static string LowUpper(string s){
                        return s.ToLower() + s.ToUpper();
                    }

                    public static void Count(string s){
                        Console.WriteLine("The amount of characters is {0}.", s.Length);
                    }
        
                    public static void Run()
                    {
                        // We encourage you to test your code with different strings,
                        // but don't forget to put the default string back at the end of your testing.
                        string s = "HeY ThErE !";
            
                        /// Change nothing down here 
                        s = LowUpper(s);
                        Console.WriteLine(s);
                        Count(s);
            
                    }
                }
            }

       */
    }
}
