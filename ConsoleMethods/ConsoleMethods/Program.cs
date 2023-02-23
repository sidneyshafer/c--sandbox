using System;
    // *** In order to use Console methods and properties, must define 'using System'

// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Drawing;

namespace ConsoleMethods
{   // class names should be pascal case (ex: ClientActivity)
    // use nouns/noun phrases to name classes (ex: Program, Employee, Date)
    // -- > used for objects
    class Program
    {   // method names shoud be pascal case (ex: CalculateValue)
        // -- > used for actions (ie. verbs)
        // use camel case for method arguments (ex: firstNummber)
        // starting point of program
        static void Main(string[] args)
        {
            // use camel case for local variables (ex: itemCount)

            // avoid abbriviations (ei. userControl, not usrCtr) for general naming
             
            // don't use numbers at the start of variable names

            // avoid underscore naming convention (only allowed at the beginning, ie. _hello)

            // avoind using predefined classes (ie. string, int, bool, double) when naming variables

            // Changing Console Colors --> using Properties
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear(); // makes color appear for entire console area, not just text

            // Console Methods
            /* Console.Write("text here") - Prints and keeps the cursor on the same line
             * Console.WriteLine("text here") - Prints and puts the cursor in the next line
             * Console.Read() - Takes a single input of type string and returns the ASCII value of that input
             * Console.ReadLine() - Takes a string OR integer input and returns it as the output value
             * Console.ReadKey() - Takes a single (character) input of type string and returns the key info
            */

            // Console.WriteLine("Hello Welcome!"); // prints text and jumps to a new line
            // Console.Write("Hello"); // prints text in the same line
            // Console.Write("Welcome!");

            // Console.ReadKey(); // program keeps running until a single character is entered


            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter any key and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();
        }
    }
}
