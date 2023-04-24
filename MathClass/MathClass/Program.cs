using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Round up a value --> Ceiling() Method
            Console.WriteLine("Ceiling : " + Math.Ceiling(15.3)); // 16
            
            // Rounds down a value --> Floor() Method
            Console.WriteLine("Floor : " + Math.Floor(16.9)); // 16
            Console.WriteLine("\n");


            // Min() and Max() Method
            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower of num1 ({0}) and num2 ({1}) is : {2}",
                num1, num2, Math.Min(num1, num2)); // 9

            Console.WriteLine("Higher of num1 ({0}) and num2 ({1}) is : {2}",
                num1, num2, Math.Max(num1, num2)); // 13
            Console.WriteLine("\n");


            // Pow() Method
            Console.WriteLine("3 to the power of 5 is : " + Math.Pow(3, 5));

            // PI Constant / Attribute
            Console.WriteLine("PI is : " + Math.PI);

            // Square Root --> Sqrt() Method
            Console.WriteLine("The square root of 25 is : " + Math.Sqrt(25));
            Console.WriteLine("\n");

            // Absolute value --> Abs() Method
            Console.WriteLine("Absolute value of -25 is : " + Math.Abs(-25));

            // Cos() Method
            Console.WriteLine("cos of 1 is : " + Math.Cos(1));

            Console.ReadKey();
        }
    }
}
