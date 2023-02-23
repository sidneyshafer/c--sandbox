using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicit Conversion
            double myDouble = 13.37;
            int myInt;
            // cast double to int
            myInt = (int)myDouble;
            Console.WriteLine(myDouble); // output 13.37
            Console.WriteLine(myInt); // output 13
            Console.Read(); // leaves console open until something is typed and the user presses enter
                // -- > after it is enterd, the code continues

            // Implicit Conversion
            // assign a smaller type value to a larger type value
            int num = 1234567;
            long bigNum = num;

            float myFloat = 14.3756F;
            double newDouble = myFloat;

            // Type Conversion
            string myString = myDouble.ToString();
            string floatString = myFloat.ToString();
            bool sunIsShining = true;
            string myBool = sunIsShining.ToString();
            int age = 18;
            age.ToString();
            Console.WriteLine(myBool); // outputs True
            Console.WriteLine(age);
            Console.WriteLine(myString);
            Console.Read();
        }
    }
}
