using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // UNARY OPERATORS
            num3 = -num1; // output = -5 (num3 = 5 * -1)
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            // ! before variable negates it
            Console.WriteLine("Is it sunny? {0}", !isSunny); // output = False

            // INCREMENT OPERATORS
            int num = 0;
            num++; // increment by 1
            Console.WriteLine("num is {0}", num); // output = 1
            Console.WriteLine("num is {0}", num++); // output = 1
            Console.WriteLine("num is {0}", num); // output = 2
            // Pre-Increment: To increment in same output, use ++ at beginning
            Console.WriteLine("num is {0}", ++num); // output = 3

            // DECREMENT OPERATORS
            int num4 = 5;
            num4--;
            Console.WriteLine("num4 is {0}", num4); // output = 4
            // pre decrement
            Console.WriteLine("num4 is {0}", --num4); // output = 3

            int result;
            // Addition
            result = num1 + num2; // (5 + 3)
            Console.WriteLine("result of num1 + num2 is {0}", result); // output = 8
            // Subtraction
            result = num1 - num2; // (5 - 3)
            Console.WriteLine("result of num1 - num2 is {0}", result); // output = 2
            // Multiplication
            result = num1 * num2; // (5 * 3)
            Console.WriteLine("result of num1 * num2 is {0}", result); // output = 15
            // Division
            result = num1 / num2; // (5 / 3)
            Console.WriteLine("result of num1 / num2 is {0}", result); // output = 1
            // Module Operator
            result = num1 % num2; // divide num1 by num2 and return the remainder (5 / 3) = 1, remainder 2
            Console.WriteLine("result of num1 % num2 is {0}", result); // output = 2

            // RELATIONAL AND TYPE OPERATORS
            // Relational:
            bool isLower;
            isLower = num1 < num2; // is 5 less than 3? --> isLower is set to false
            Console.WriteLine("result of num1 < num2 is {0}", isLower); // output = False
            isLower = num1 > num2; // is 5 greater than 3? --> isLower is set to true
            Console.WriteLine("result of num1 > num2 is {0}", isLower); // output = True

            // Equality Operator
            // == comparing, = assigning
            bool isEqual;
            isEqual = num1 == num2; // is 5 equal to 3? --> isEqual is set to false
            Console.WriteLine("result of num1 == num2 is {0}", isEqual); // output = False
            isEqual = num1 != num2; // is 5 not equal to 3? --> isEqual is set to true
            Console.WriteLine("result of num1 != num2 is {0}", isEqual); // output = True

            // CONDITIONAL OPERATORS
            bool isLowerAndSunny;
            // condition1 AND condition2 (&&)
            isLowerAndSunny = isLower && isSunny; // the statement is only true if both statements are true
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny); // output = True
            isLower = false;

            // condition1 OR condition2 (||)
            isLowerAndSunny = isLower || isSunny; // statement is true of one condition is true
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny); // output = True


            Console.ReadKey();
        }
    }
}
