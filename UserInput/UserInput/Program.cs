using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something: ");
            // Get user input from the console and save to the 'input' variable
            string input = Console.ReadLine();
            // Print what the user entered to the console
            Console.WriteLine("You entered: {0}", input);

            Console.WriteLine(Calculate());
            
            // Keep the console open and running until the user enters something
            Console.Read();


        }

        public static int Calculate()
        {
            Console.WriteLine("Enter the first number:");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string num2Input = Console.ReadLine();

            // Convert strings to int
            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);
            
            
            int result = num1 + num2;
            return result;
        }
    }
}
