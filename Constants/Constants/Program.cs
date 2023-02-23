using System;

namespace Constants
{
    // Constants are immutable values which are known
    // at compile time and do not change for the life of the program

    class Program
    {
        // constants as fields
        // defined in the class before the main method

        const double PI = 3.1415926359;
        const int weeks = 52, months = 12;
        const string myBirthday = "March 30th, 2004"; // 03.30.2004

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always on: {0}", myBirthday);
            Console.ReadKey(); // program keeps running until a single key is entered

        }
    }
}
