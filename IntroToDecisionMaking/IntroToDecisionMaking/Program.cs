using System;

namespace IntroToDecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF STATEMENT
            /*
             
             if (condition1) {
                // what to do if condition1 is met
              } else if (condition2) {
                // what to do if condition1 is not met, but condition2 is met
              } else {
                // what to do if none of the conditions are met

            */
            Console.WriteLine("What's the temperature today?");
            string temperature = Console.ReadLine();
            // int numTemp = int.Parse(temperature);
            int numTemp;
            int number;

            // TryParse
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a valid number. 0 set as temperature.");
            }
            
            
            if (numTemp < 20)
            {
                Console.WriteLine("Put on a coat");
            } else if (numTemp == 20) {
                Console.WriteLine("Pants and pull over should be fine");
            } else if (numTemp > 20) {
                Console.WriteLine("Shorts are good enough");
            } else {
                Console.WriteLine("No temperature provided");
            }

            // TryParse Method
            /*
                * Converting string into numeric data types
                * You can convert a string like "128" into a numeric data type
                  like an integer.
                * Can also use float or double to parse --> float.TryParse() or double.TryParse
                * Fails to parse if there is are string characters in the numeric string
                
                1. Get a string

                    string numberAsString = "128";

                2. Create a variable to store the parsed value

                    string numberAsString = "128";
                    int parsedValue;

                3. Try to parse the string (returns a boolean)

                    string numberAsString = "128";
                    int parsedValue;
                    bool success = int.TryParse(numberAsString, out parsedValue);

                    // The returned boolean is true when parsing was successful

                4. Work with the result

                    string numberAsString = "128";
                    int parsedValue;
                    bool success = int.TryParse(numberAsString, out parsedValue);

                    if (success) {
                        Console.WriteLine("Parsing successful - number is " + parsedValue);
                    } else {
                        Console.WriteLine("Parsing failed");
                    }
            */

            Console.ReadKey();
        }
    }
}
