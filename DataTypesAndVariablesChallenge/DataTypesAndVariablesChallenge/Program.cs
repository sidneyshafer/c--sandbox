using System;

namespace DataTypesAndVariablesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable for each datatype
            byte myByte = 25; // 0 to 255
            Console.WriteLine(myByte); 
            
            sbyte mySbyte = -15; // -128 to 127
            Console.WriteLine(mySbyte);
            
            int myInt = -12318925; // -2,147,483,648 to 2,147,483,647
            Console.WriteLine(myInt);
            
            uint myUint = 123091; // 0 to 4294967295
            Console.WriteLine(myUint);
            
            short myShort = -32768; // -32,768 to 32,767
            Console.WriteLine(myShort);
            
            ushort myUshort = 65535; // 0 to 65535
            Console.WriteLine(myUshort);

            long myLongNum = 9999999999999; // -9223372036854775808 to 9223372036854775807
            Console.WriteLine(myLongNum);

            ulong myUlongNum = 1234567890000; // 0 to 18446744073709551615
            Console.WriteLine(myUlongNum);

            float myFloat = -31.1289f; // -3.402823e38 to 3.402823e38
            Console.WriteLine(myFloat);
            
            double myDouble = -12.1231250d; // -1.79769313486232e308 to 1.79769313486232e308
            Console.WriteLine(myDouble);

            decimal myDecimal = 12.23456789m; // Precise fractional or integral type
                                              // that can represent decimal numbers with
                                              // 29 significant digits
            Console.WriteLine(myDecimal);
            
            char myChar = 'S'; // Unicode symbols used in text
            Console.WriteLine(myChar);
            
            bool myBool = false; // True or false
            Console.WriteLine(myBool);
            
            string myText = "I control text"; // A sequence of characters
            Console.WriteLine(myText);
            string numText = "15";

            // Parse numText to int
            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
