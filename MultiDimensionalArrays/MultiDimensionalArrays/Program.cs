using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare 2D Array
            string[,] matrix;

            // Declare 3D Array
            int[,,] threeD;

            // 4D
            // string[,,,] fourD;

            // 5D
            // int[,,,,] fiveD;

            // Initialize Arrays
            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3}, // row 0
                {4, 5, 6}, // row 1
                {7, 8, 9}, // row 2
            };

            // Access number 5
            Console.WriteLine("Central value is {0}.", array2D[1, 1]);
            // Get number 7
            Console.WriteLine("The first number in the third row is {0}.", array2D[2, 0]);

            // 3D Array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi", "Hello"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"By", "See Ya" }
                }
            };

            Console.WriteLine("First value in 3D array is {0}.", array3D[0, 0, 0]);
            Console.WriteLine("The value is '{0}'.", array3D[0,2,0]);
            Console.WriteLine("---------------------------");

            string[,] array2DString = new string[3, 2] 
            { 
                { "one", "two", }, 
                { "three", "four" }, 
                { "five", "six" } 
            };

            Console.WriteLine("Value is {0}", array2DString[1,1]);

            // Change values in array
            array2DString[1, 1] = "chicken";

            Console.WriteLine("The new value is {0}", array2DString[1, 1]);

            // Find dimensions of array
            int dimensions = array2DString.Rank;
            Console.WriteLine("The dimensions are {0}", dimensions);

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.ReadKey();
        }
    }
}