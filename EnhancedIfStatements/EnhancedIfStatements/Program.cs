using System;

namespace EnhancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entire if statement in one line (short cut if statements)

            /* General Syntax:
                    condition ? first_expression : second_expression

               * Condition has to be either true or false
               * The conditional operator is right - associative
               * The expression: 
                    a ? b: c ? d : e 
                    
                    is evaluated as:
                    a ? b : (c ? d : e), NOT --> (a ? b : c) ? d: e
               
               * The conditional operator cannot be overloaded.
            */


            int temperature = -5;
            string stateOfMatter;

            
            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            temperature += 30;

            // Above if statement as Ternary Operator:
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            // Challenge: add gas state of matter options
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            Console.ReadKey();

        }
    }
}
