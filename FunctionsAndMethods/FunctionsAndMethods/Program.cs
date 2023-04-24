using System;

namespace FunctionsAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Syntax
            /*
                <Access Specifier> <Return Type> <Method Name>(Parameter List)
                    {
                        Method Body
                    }
                
            Access Specifier - The access specifier determines the visibility of a 
            variable or a method from another class.

            Return Type - A method may return a value. The return type us the data
            type of the value the method returns. If the method is not returning any
            values, then the return type is void.

            Method Name - Method name is a unique identifier and it is case sensitive.
            It cannot be the same as any other identifier declared in the class.

            Parameter List - Enclosed between parentheses, the parameters are used to pass
            and recieve data from a method. The parameter list refers to the type,
            order, and number of the parameters of a method. Parameters are optional;
            that is, a method may contain no parameters.

            Method Body - This contains the set of instructions needed to complete the
            required activity.

            *** Example: ***

            public int Add(int num1, int num2) {
                int result = num1 + num2;
                return result;
            }

            public int Add(int num1, int num2) {
                return num1 + num2;
            }

            */

            // Call WriteSomething() Method inside Main Method
            WriteSomething();

            // Call WriteSomethingSpecific Method and provide an argument
            WriteSomethingSpecific("I am an argument and am called from a method.");

            // Call Add() Method and provide two arguments
            int result = Add(Add(1, 2), Add(3, 4));
            Console.WriteLine(result);

            Console.WriteLine(Add(5, 10));

            Console.WriteLine(Multiply(3, 5));

            Console.WriteLine(Add(Multiply(3, 5), Multiply(2, 5)));

            Console.WriteLine(Divide(30, 7));

            Console.Read();
        }

        // VOID METHODS
        // Create method outside of Main Method
        // Must include 'static' keyword in order to call method in main function
        // access modifier (static), return type (void),
        // method name (WriteSomething), parenthesis (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("Hi! I am called from a method");
        }

        // Create method with parameter
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        // METHODS WITH RETURN VALUES
        // ** NOT void
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
