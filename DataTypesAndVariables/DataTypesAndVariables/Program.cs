using System;

namespace DataTypesAndVariables
{
    class Program
    {
        /// <summary>
        /// This is a cool method
        /// </summary>
        static void CoolMethod()
        {
            // cool method
        }
        static void Main(string[] args)
        {
            // declare a variable
            int num1;
            // assign a value to a variable
            num1 = 13;
            // declaring and initializing a variable in one line
            int num2 = 23;
            int sum = num1 + num2;

            Console.WriteLine(sum);

            // using concatination
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            // declaring multiple variables at once
            int num3, num4, num5;

            // Double
            double d1 = 3.14159;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is: " + dDiv);

            // Float
            // Not as precise as double
            float f1 = 3.14159f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is: " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 is: " + dIDiv);

            // int dIDivInt = d1 / num1; **** Not allowed

            // Strings -- is a Class not a primitive data point
            // type string is from class String in System namespace
            string myName = "Sidney";
            string message = "My name is " + myName;

            // String methods
            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();

            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
            Console.WriteLine("Hello " + myName);

            CoolMethod();

            Console.Read(); // leaves command window open

            // VALUE vs REFERENCE TYPES
            /* Value Type:
             * A data type which when declared and assigned a value, holds the value
                directly on its own memory space.
               * Uses a heap to store the value
               * Examples: int, float, long, double, char, bool, decimal, etc.
               
              Reference Type:
              * A variable type which instead of storing the value in memory directly,
                  stores the memory location of the actual data.
              * The variable here stores the memory refernece of the data and not
                   the data directly.
              * Examples: string, class, Array, etc. (larger, more complex data types)
              * When we copy this reference type of a data type it will just copy the
                memory address of the data so we will then have two variables pointing
                to the same data
            */
        }
    }
}
