using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse a string to an int
            string myString = "15";
            string mySecondString = "13";
            string result = myString + mySecondString;

            string myDouble = "4.35";
            string mySecondDouble = "5.12";

            double doubleResult = double.Parse(myDouble) + double.Parse(mySecondDouble);

            int num1 = Int32.Parse(myString); // use Parse() method to convert string to int
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            
            Console.WriteLine(result);
            Console.WriteLine(resultInt);
            Console.WriteLine(doubleResult);

            // Parsing Assignment
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float newFloat = float.Parse(stringForFloat);
            int newInt = Int32.Parse(stringForInt);

            // String Mamipulation
            int myAge = 18;
            string myName = "Sidney";
            double myFavNumber = 3.14D;

            // 1. String concatenation
            Console.WriteLine("String Concatenation!");
            Console.WriteLine("Hello my name is " + myName + ", I am " + myAge + " years old.");

            // 2. String formatting - uses indexes
            Console.WriteLine("String Formatting!");
            Console.WriteLine("Hello my name is {0}, I am {1} years old and " +
                "my favorite number is {2}.", myName, myAge, myFavNumber);

            // 3. String interpolation
            // uses a $ at the start which will allow us to write
            // our variables like this {variableName}
            Console.WriteLine("String Interpolation!");
            Console.WriteLine($"Hello my name is {myName}, I am {myAge} years old.");
            
            // 4. Verbatim Strings
            // verbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet,

            consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
            labore et dolore magna aliqua. Ut enim ad minim veniam, 
            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 



            Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
            Excepteur sint occaecat cupidatat non proident, 
            sunt in culpa qui officia deserunt mollit anim id est laborum.");

            // would produce an error without '@' at front
            Console.WriteLine(@"C:\User\Admin\Pictures\Pig\SuperCoolPig.png");
            // valid escape characters won't work
            Console.WriteLine(@"This \n will not work.");

            // String and Some String Methods
            // string is an object of the System.String class. A sequence of characters

            // SubString(int32) - is used to get the substring from the string,
            // starting from the specified index

            // ToLower - is used to convert the string to lowercase.
            // ToUpper - is used to convert the string to uppercase.
            // Trim() - is used to trim all leading and trailing white space from the string.
            // IndexOf(string) - is used to get the first occurrence of the string
            // or character inside the string.

            // IsNullOrWhiteSpace - returns true if the string is either null or is blank
            // else it returns false.

            // Demonstrating String Functions
            string firstName = "Sidney";
            string lastName = "Shafer";
            string fullName = string.Concat(firstName, " ", lastName); 
            Console.WriteLine(fullName); // output: Sidney Shafer
            Console.WriteLine(firstName.Substring(1)); // output: idney
            Console.WriteLine(fullName.ToLower()); // output: sidney shafer
            Console.WriteLine(lastName.ToUpper()); // output: SHAFER
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(firstName.IndexOf('S')); // output: 0
            Console.WriteLine(string.IsNullOrWhiteSpace(firstName)); // output: false

            // String.Format
            // - is used to insert the object or variable value inside any string
            // - we can replace the value in the specified format
            // - Syntax: String.Format("any string {index}", object);

            Console.ReadKey();

            // Console.Read();
        }
    }
}
