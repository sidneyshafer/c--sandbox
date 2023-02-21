using System;

namespace ArraysBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basics of Arrays
            /*
             * Stores a fixed size sequential collection of elements.
             * Can ONLY create an array of the same types.
             * Can create an array of all types: int, string, object, etc.
             * Great to store a collection of data - easier to think of a collection
               of variables of the same type stored at contituous memory locations.
             * Stores values at indexes starting at 0
             
             * Declaring an array:
               dataType[] arrayName; 
               
               Example: int[] grades;


             * Initializing an array:
               dataType[] arrayName = new dataType[amountOfEntries];

               Example: int[] grades = new int[5];
            
             * Assigning values to an array:
               arrayName[index] = value;

               Example:
                grades[0] = 15;
                grades[1] = 12;
            
             */

            // Declaring and Initializing Arrays
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 25;

            Console.WriteLine("Grades at index 0 is {0}.", grades[0]);
            Console.WriteLine("Enter a new grade for index 0:");

            string input = Console.ReadLine();
            // Assign a new value to array grades at index 0
            grades[0] = int.Parse(input);

            Console.WriteLine("Grades at index 0: {0}", grades[0]);

            // Another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // Third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 14, 7, 9, 18, 20, 3 };

            // Get length of array
            Console.WriteLine("Length of Grades A is: {0}.", gradesOfMathStudentsA.Length);
            Console.WriteLine("Length of Grades B is: {0}.", gradesOfMathStudentsB.Length);
            Console.ReadKey();
        }
    }
}
