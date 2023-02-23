using System;

namespace BasicsAndForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Loop Types: 
                    * for loop
                    * while loop (check then go)    
                    * do while loop (do first then check)
                    * foreach loop (run through array or list)
                
                For Loop:
                    for (start value; condition; increment) {
                        // code body
                    }
                    
                    * --> Great for counters
                
                While Loop:
                    counterVariable = 0;
                    while (condition) {
                        // execute code
                        counterVariable++;
                    }

                    * --> Executes code as long as the condition is met
                
                Do While Loop:
                    counterVariable = 0;
                    do {
                        // execute code
                        counterVariable++;
                    } while (condition)

                    * --> Executes code as long as the condition is met
                    * --> Does code first, then checks condition
                    * --> Will repeat if condition is true, but will run at least once
                
                For Each Loop:
                    * Runs through an array
                    * Only as long as there is content
                    * **More in 'arrays' section

            */

            // For Loops Example
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            } // output = 0,1,2,3,4,5,6,7,8,9

            for (int i = 0; i < 50; i+=5)
            {
                Console.WriteLine(i);
            } // output = 0,5,10,15,20,25,30,35,40,45

            // Prints odd numbers between 0 and 20
            for (int i = 1; i < 20; i+=2)
            {
                Console.WriteLine(i);
            } // output = 1,3,5,7,9,11,13,15,17,19

            Console.ReadKey();
        }
    }
}